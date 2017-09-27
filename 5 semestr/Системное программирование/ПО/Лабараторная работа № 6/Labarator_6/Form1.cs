using System;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.Permissions;
[assembly: RegistryPermission(SecurityAction.RequestMinimum, ViewAndModify = "HKEY_CURRENT_USER")]



namespace Labarator_6
{
    public partial class Form1 : Form
    {
        #region Конструктор

        public Form1()
        {
            InitializeComponent( );
            //
            // Отображение программ на автозапуске
            //
            using ( RegistryKey startUp = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run"))
            {
                foreach (var name in startUp.GetValueNames( ))
                {
                    txtConsole.Text += name;
                    txtConsole.Text += Environment.NewLine;
                }
            }
        }

        #endregion

        #region Свойства

        #endregion

        #region Методы


        RegFindValue RegFind( RegistryKey key, string find )
        {
            if (key == null || string.IsNullOrEmpty(find))
                return null;

            string[] props = key.GetValueNames( );

            object value = null;

            if (props.Length != 0)
            {
                foreach (string property in props)
                {
                    if (property.IndexOf(find, StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        return new RegFindValue(key, property, null, RegFindIn.Property);
                    }

                    value = key.GetValue(property, null, RegistryValueOptions.DoNotExpandEnvironmentNames);
                    if (value is string && ((string)value).IndexOf(find, StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        return new RegFindValue(key, property, (string)value, RegFindIn.Value);
                    }
                }
            }


            string[] subkeys = key.GetSubKeyNames( );

            RegFindValue retVal = null;

            if (subkeys.Length != 0)
            {
                foreach (string subkey in subkeys)
                {
                    try
                    {
                        retVal = RegFind(key.OpenSubKey(subkey, RegistryKeyPermissionCheck.ReadSubTree), find);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    if (retVal != null)
                    {
                        return retVal;
                    }
                }
            }

            key.Close( );

            return null;
        }


        /// <summary>
        /// Установка диспетчера задач
        /// </summary>
        /// <param name="enable"></param>
        public void SetTaskManager( bool flag )
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(
                @"Software\Microsoft\Windows\CurrentVersion\Policies\System");

            if (flag && key.GetValue("DisableTaskMgr") != null)
            {
                key.DeleteValue("DisableTaskMgr");
            }
            else
            {
                key.SetValue("DisableTaskMgr", "1");
            }

            key.Close( );
        }


        /// <summary>
        /// Установка значения Regedit
        /// </summary>
        /// <param name="enable"></param>
        public void SetRegedit( bool flag )
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(
                @"Software\Microsoft\Windows\CurrentVersion\Policies\System");

            if (flag && key.GetValue("DisableRegistryTools") != null)
            {
                key.DeleteValue("DisableRegistryTools");
            }
            else
            {
                key.SetValue("DisableRegistryTools", 1);
            }
            key.Close( );
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="rkey"></param>
        /// <param name="textBox0"></param>
        void PrintKeys( RegistryKey rkey, TextBox textBox0 )
        {
            String[] names = rkey.GetSubKeyNames( );

            int icount = 0;
            foreach (String s in names)
            {
                textBox0.Text += s + "\r\n";

                icount++;
                if (icount >= 10)
                    break;
            }
        }

        #endregion

        #region кнопки

        /// <summary>
        /// Кнопка включение доступа к диспетчеру задач
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTaskMOn_Click( object sender, EventArgs e )
        {
            btnTaskMOff.Visible = false;
            btnTaskMOn.Visible = true;
            SetTaskManager(true);

        }

        /// <summary>
        /// Кнопка выключение доступа к диспетчеру задач
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTaskMOff_Click( object sender, EventArgs e )
        {
            btnTaskMOff.Visible = true;
            btnTaskMOn.Visible = false;
            SetTaskManager(false);
        }

        /// <summary>
        /// Кнопка включение доступа к Regedit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegOn_Click( object sender, EventArgs e )
        {
            btnRegOn.Visible = true;
            btnRegOff.Visible = false;
            SetRegedit(true);
        }

        /// <summary>
        /// Кнопка выключение доступа доступа к Regedit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegOff_Click( object sender, EventArgs e )
        {
            btnRegOn.Visible = false;
            btnRegOff.Visible = true;
            SetRegedit(false);
        }

      

        /// <summary>
        /// Добаление ключа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKeyAdd_Click( object sender, EventArgs e )
        {
            RegistryKey key;
            key = Registry.CurrentUser.CreateSubKey("SP_Labarator_#_6");
            key.SetValue(txtKeyName.Text, txtKeyValue.Text);
            key.Close( );

        }

        /// <summary>
        /// Удаление ключа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKeyRemove_Click( object sender, EventArgs e )
        {
           
            try
            {
                RegistryKey key;
                key = Registry.CurrentUser.CreateSubKey("SP_Labarator_#_6");
                
                key.DeleteValue(txtKeyName.Text);
                key.Close( );
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message );
            }

            
        }

        /// <summary>
        /// Редактирование ключа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKeyEdit_Click( object sender, EventArgs e )
        {
            RegistryKey key = Registry.CurrentUser;
            RegistryKey edit_key = key.OpenSubKey(txtKeyName.Text, true);
            key.SetValue(txtKeyName.Text, txtNewKeyValue.Text);
            key.Close( );
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click( object sender, EventArgs e )
        {

            RegistryKey key = Registry.Users;
            PrintKeys(key, txtConsole);

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click_1( object sender, EventArgs e )
        {
            RegistryKey[] keys = { Registry.ClassesRoot, Registry.CurrentConfig, Registry.LocalMachine, Registry.CurrentUser, Registry.Users };

            foreach (RegistryKey key in keys)
            {
                RegFindValue retVal = RegFind(key, txtFindValue.Text);

                if (retVal != null)
                {
                    txtConsole.Text += retVal.Key.Name + " " + retVal.Property.ToString( ) + Environment.NewLine + "\r\n";

                }
            }
        }

        #endregion
    }


    class RegFindValue
    {
        RegistryKey regKey;

        string mProps;

        string mVal;

        RegFindIn mWhereFound;

        public RegistryKey Key
        {
            get
            {
                return regKey;
            }
        }

        public string Property
        {
            get
            {
                return mProps;
            }
        }

        public string Value
        {
            get
            {
                return mVal;
            }
        }

        public RegFindIn WhereFound
        {
            get
            {
                return mWhereFound;
            }
        }

        public RegFindValue( RegistryKey key, string props, string val, RegFindIn where )
        {
            regKey = key;
            mProps = props;
            mVal = val;
            mWhereFound = where;
        }
    }

    enum RegFindIn
    {
        Property,
        Value
    }

   


}
