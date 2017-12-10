object form_line: Tform_line
  Left = 257
  Top = 195
  BorderStyle = bsDialog
  Caption = 'Line Properties'
  ClientHeight = 150
  ClientWidth = 213
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
  object BitBtn1: TBitBtn
    Left = 128
    Top = 80
    Width = 75
    Height = 25
    TabOrder = 0
    OnClick = BitBtn1Click
    Kind = bkOK
  end
  object BitBtn2: TBitBtn
    Left = 128
    Top = 112
    Width = 75
    Height = 25
    TabOrder = 1
    OnClick = BitBtn2Click
    Kind = bkCancel
  end
  object RadioGroup1: TRadioGroup
    Left = 8
    Top = 8
    Width = 105
    Height = 129
    Caption = 'Line Style'
    ItemIndex = 0
    Items.Strings = (
      'Solid'
      'Dash'
      'Dot'
      'DashDot'
      'DashDotDot')
    TabOrder = 2
  end
  object RadioGroup2: TRadioGroup
    Left = 128
    Top = 8
    Width = 73
    Height = 65
    Caption = 'Line Width'
    ItemIndex = 0
    Items.Strings = (
      '1'
      '2'
      '3')
    TabOrder = 3
  end
end
