   M S B A M L   `   `   `  ���� A  =Servis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Servis.DijaloziServis.Dijalozi  #    Servis.Dijalozi.korisnicixaml   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:Servis.Dijalozi       � Title$  korisnicixaml��$	��450��$	��800��.���  � ColumnDefinitions �� ����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color# � �� � Offset$ 1Q�� $ 	#FF2E17F9��.+��� $��Id��$
��Left=�$��	29,31,0,0q�$	��Top=� J� RenderTransformOrigin$ 0.552,-0.039&��� $	��Ime��$
��Left=�$��	29,65,0,0q�$	��Top=��� $��Prezime��$
��Left=�$	��Top=�$��	29,96,0,0q�$ 0.423,1.266&��� $��Broj telefona��$
��Left=�$��
29,127,0,0q�$	��Top=��� -    ��Name$ 
id_textBox��$
��Left=�$��23��$��
102,35,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��184��.������ 	 �� Path$	 Id�
 �� UpdateSourceTrigger$
 PropertyChanged=� �� ValidationRules .�� =� ErrorTemplate �� .R��  � RowDefinitions ��  �� �� $
��Auto �.+���  ��Name$ textBox��$��0��$��0���� $��1��$��0��
���  ��$	��Top=�$��22(�$��Medium"����� *[0].ErrorContent+.���� -   $ brojTelefona_textBox��$
��Left=�$��23��$��103,130,0,0q�$
 Wrap=�$	��Top=�$	��184������ *BrojTelefona+ �� Mode$ TwoWay=��� -   $ prezime_textBox��$
��Left=�$��23��$��
102,99,0,0q�$
 Wrap=�$	��Top=�$	��184������ *	Prezime+$ TwoWay=��� -   $ ime_textBox��$
��Left=�$��23��$��
103,68,0,0q�$
 Wrap=�$	��Top=�$	��184������ *	Prezime+$ TwoWay=��� -    ��Name$ sacuvaj��$��Sacuvaj��$
��Left=�$��102,267,0,0q�$	��Top=�$��75���� -   $��Odustani��$
��Left=�$��212,267,0,0q�$	��Top=�$��75��