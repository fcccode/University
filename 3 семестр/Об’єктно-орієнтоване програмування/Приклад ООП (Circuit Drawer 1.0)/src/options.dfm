object form_options: Tform_options
  Left = 263
  Top = 216
  BorderStyle = bsDialog
  Caption = 'Options'
  ClientHeight = 147
  ClientWidth = 371
  Color = clBtnFace
  Font.Charset = DEFAULT_CHARSET
  Font.Color = clWindowText
  Font.Height = -11
  Font.Name = 'MS Sans Serif'
  Font.Style = []
  OldCreateOrder = False
  Position = poMainFormCenter
  OnShow = FormShow
  PixelsPerInch = 96
  TextHeight = 13
  object Label1: TLabel
    Left = 16
    Top = 64
    Width = 28
    Height = 13
    Caption = 'Width'
  end
  object Label2: TLabel
    Left = 16
    Top = 96
    Width = 31
    Height = 13
    Caption = 'Height'
  end
  object BitBtn1: TBitBtn
    Left = 192
    Top = 8
    Width = 75
    Height = 25
    TabOrder = 0
    OnClick = BitBtn1Click
    Kind = bkOK
  end
  object BitBtn2: TBitBtn
    Left = 192
    Top = 40
    Width = 75
    Height = 25
    TabOrder = 1
    OnClick = BitBtn2Click
    Kind = bkCancel
  end
  object cbShowGrid: TCheckBox
    Left = 16
    Top = 8
    Width = 97
    Height = 17
    Caption = 'Show Grid'
    TabOrder = 2
  end
  object cbAlign: TCheckBox
    Left = 16
    Top = 32
    Width = 97
    Height = 17
    Caption = 'Align to Grid'
    TabOrder = 3
  end
  object Edit1: TEdit
    Left = 56
    Top = 64
    Width = 121
    Height = 21
    TabOrder = 4
    Text = 'Edit1'
  end
  object Edit2: TEdit
    Left = 56
    Top = 96
    Width = 121
    Height = 21
    TabOrder = 5
    Text = 'Edit2'
  end
  object grid_step: TRadioGroup
    Left = 272
    Top = 8
    Width = 81
    Height = 65
    Caption = 'Grid Step'
    ItemIndex = 1
    Items.Strings = (
      '4'
      '8'
      '16')
    TabOrder = 6
  end
end
