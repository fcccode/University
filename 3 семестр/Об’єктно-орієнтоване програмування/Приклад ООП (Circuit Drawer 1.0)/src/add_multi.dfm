object form_multi: Tform_multi
  Left = 329
  Top = 218
  BorderStyle = bsDialog
  Caption = 'form_multi'
  ClientHeight = 174
  ClientWidth = 322
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poScreenCenter
  PixelsPerInch = 96
  TextHeight = 13
  object Bevel1: TBevel
    Left = 8
    Top = 24
    Width = 105
    Height = 105
  end
  object Image1: TImage
    Left = 8
    Top = 24
    Width = 105
    Height = 105
  end
  object Label1: TLabel
    Left = 8
    Top = 8
    Width = 36
    Height = 13
    Caption = 'Picture:'
  end
  object Label2: TLabel
    Left = 136
    Top = 24
    Width = 33
    Height = 13
    Caption = 'X step:'
  end
  object Label3: TLabel
    Left = 136
    Top = 48
    Width = 33
    Height = 13
    Caption = 'Y step:'
  end
  object Label4: TLabel
    Left = 136
    Top = 96
    Width = 68
    Height = 13
    Caption = 'Vertical count:'
  end
  object Label5: TLabel
    Left = 136
    Top = 72
    Width = 80
    Height = 13
    Caption = 'Horizontal count:'
  end
  object BitBtn1: TBitBtn
    Left = 136
    Top = 136
    Width = 75
    Height = 25
    Enabled = False
    TabOrder = 0
    OnClick = BitBtn1Click
    Kind = bkOK
  end
  object BitBtn2: TBitBtn
    Left = 232
    Top = 136
    Width = 75
    Height = 25
    TabOrder = 1
    OnClick = BitBtn2Click
    Kind = bkCancel
  end
  object Button1: TButton
    Left = 8
    Top = 136
    Width = 107
    Height = 25
    Caption = 'Load Picture...'
    TabOrder = 2
    OnClick = Button1Click
  end
  object Edit1: TEdit
    Left = 176
    Top = 24
    Width = 121
    Height = 21
    ReadOnly = True
    TabOrder = 3
    Text = '64'
  end
  object Edit2: TEdit
    Left = 176
    Top = 48
    Width = 121
    Height = 21
    ReadOnly = True
    TabOrder = 4
    Text = '64'
  end
  object UpDown1: TUpDown
    Left = 297
    Top = 24
    Width = 13
    Height = 21
    Associate = Edit1
    Min = 0
    Max = 1000
    Increment = 8
    Position = 64
    TabOrder = 5
    Wrap = True
  end
  object UpDown2: TUpDown
    Left = 297
    Top = 48
    Width = 13
    Height = 21
    Associate = Edit2
    Min = 0
    Max = 1000
    Increment = 8
    Position = 64
    TabOrder = 6
    Wrap = True
  end
  object Edit3: TEdit
    Left = 216
    Top = 96
    Width = 81
    Height = 21
    ReadOnly = True
    TabOrder = 7
    Text = '2'
  end
  object Edit4: TEdit
    Left = 216
    Top = 72
    Width = 81
    Height = 21
    ReadOnly = True
    TabOrder = 8
    Text = '2'
  end
  object UpDown3: TUpDown
    Left = 297
    Top = 96
    Width = 12
    Height = 21
    Associate = Edit3
    Min = 1
    Position = 2
    TabOrder = 9
    Wrap = False
  end
  object UpDown4: TUpDown
    Left = 297
    Top = 72
    Width = 12
    Height = 21
    Associate = Edit4
    Min = 1
    Position = 2
    TabOrder = 10
    Wrap = False
  end
  object open_pict1: TOpenPictureDialog
    Left = 72
    Top = 88
  end
end
