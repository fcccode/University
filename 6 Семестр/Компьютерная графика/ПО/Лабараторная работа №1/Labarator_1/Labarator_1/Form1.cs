using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Labarator_1
{
    public partial class picture : Form
    {
        #region Переменные 
        Graphics drawArea;
        private int horizont  = 180;
        private int height;
        private int width;
        private int curSunSize = 30;
        private int curSunPosition = 100;
        private int startX0 = 150;
        private int startY0 = 150;
        #endregion

        #region Контруктор 

        /// <summary>
        /// Инициализация компонентов формы
        /// </summary>
        public picture()
        {
            InitializeComponent();
            drawArea = drawingArea.CreateGraphics();
            Init();   
        }
        #endregion

        #region Методы 

        /// <summary>
        /// Инициализация переменных
        /// </summary>
        private void Init()
        {
            height = drawingArea.Height;
            width =  drawingArea.Width;
        }

        /// <summary>
        /// Сбор рисунков в правильной последовательности
        /// </summary>
        private void Compositor()
        {
            try {
                // прежде чем перерисовать очищаем 
                drawArea.Clear(Color.DeepSkyBlue);
                DrawHorizon(drawArea);
                DrawSun(drawArea);
                DrawHouse(drawArea);
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Отрисовка горизонта
        /// </summary>
        private void DrawHorizon(Graphics area)
        {
            using (SolidBrush rectBrush = new SolidBrush(Color.Green))
            {
                Rectangle rect = new Rectangle(0, (height - horizont), width, height);
                area.DrawRectangle(new Pen(Color.Green, 3), rect);
                area.FillRectangle(rectBrush, rect);
            }
        }

        /// <summary>
        /// Отрисовка солнца
        /// </summary>
        /// <param name="area"></param>
        private void DrawSun(Graphics area)
        {      
            using (SolidBrush sunBrush = new SolidBrush(Color.Yellow))
            {
                Rectangle rect = new Rectangle(curSunPosition, 10, curSunSize, curSunSize);
                area.DrawEllipse(new Pen(Color.Yellow), rect);
                area.FillEllipse(sunBrush, rect);
            }
        }

        /// <summary>
        /// Отрисовка дома
        /// </summary>
        /// <param name="drawArea"></param>
        private void DrawHouse(Graphics area)
        {        
            int houseWidth = 150;
            int houseHeight = 75;

            var winWidth = 25;
            var winHeigth = 30;

            // коробка дома
            using (Brush br2 = new SolidBrush(Color.Brown))
            {
                var houseRect = new Rectangle(startX0, startY0, houseWidth, houseHeight);
                area.DrawRectangle(Pens.Black, houseRect);
                area.FillRectangle(new SolidBrush(Color.Black), houseRect);

                // левое окно
                var windowLeftRect = new Rectangle(startX0 + 10, startY0 + 15, winWidth, winHeigth);
                area.DrawRectangle(Pens.Black, windowLeftRect);
                area.FillRectangle(new SolidBrush(Color.Yellow), windowLeftRect);

                // правое окно
                var windwRigthRect = new Rectangle(startX0 + houseWidth - winWidth - 10, startY0 + 15, winWidth, winHeigth);
                area.DrawRectangle(Pens.Black, windwRigthRect);
                area.FillRectangle(new SolidBrush(Color.Yellow), windwRigthRect);

                // размеры двери
                var doorWidth = 30;
                var doorHeigth = 60;
                var doorStartX0 = startX0 + (houseWidth / 2) - (doorWidth / 2);

                // дверь
                var doorRect = new Rectangle(doorStartX0, startY0 + 15, doorWidth, doorHeigth);
                area.DrawRectangle(Pens.Black, doorRect);
                area.FillRectangle(new SolidBrush(Color.Red), doorRect);

                // точки для крыши
                Point leftPoint = new Point(startX0, startY0);
                Point rightPoint = new Point(startX0 + houseWidth, startY0);

                // размеры и координаты крыши
                var floorHeight = 65;
                var middleX = startX0 + (houseWidth / 2);
                var moddleY = startY0 - floorHeight;
                Point middlePoint = new Point(middleX, moddleY);

                // прорисовка по пути
                GraphicsPath path = new GraphicsPath();
                path.AddLine(leftPoint, middlePoint);
                path.AddLine(middlePoint, rightPoint);
                area.DrawPath(Pens.Green, path);         
                area.FillPath(br2, path);
            }
        }

        #endregion

        #region Обработчики событий 

        /// <summary>
        /// Нажатие кнопки отрисовки
        /// </summary>
        private void btnDraw_Click(object sender, EventArgs e)
        {
            Compositor();
        }
        #endregion
    }
}
