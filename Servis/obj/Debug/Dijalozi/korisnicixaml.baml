   M S B A M L   `   `   `  ����A  =Servis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Servis.DijaloziServis.Dijalozi  5   	   #    Servis.Dijalozi.korisnicixaml   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Servis.Dijalozi     5   	     � Title$  korisnicixaml��5   	   $	��450��6   $	��800��6,   .��5	      �  � ColumnDefinitions 5   
   �� 5      ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color# � ��6    � Offset$ 1Q�6^   � 5      $ 	#FF2E17F9��6   5      .+�5   
   �� $��Id��6   $
��Left=�6   $��	29,31,0,0q�68   $	��Top=�6K    J� RenderTransformOrigin$ 0.552,-0.039&�6c   �� 5   
   $	��Ime��6   $
��Left=�6   $��	29,65,0,0q�69   $	��Top=�6L   �� 5   
   $��Prezime��6   $
��Left=�6"   $	��Top=�6=   $��	29,96,0,0q�6U   $ 0.423,1.266&�6h   �� 5   
   $��Broj telefona��6   $
��Left=�6(   $��
29,127,0,0q�6C   $	��Top=�6W   �� 5   
   -   5         ��Name$ 
id_textBox��5      $
��Left=�6&   $��23��6A   $��
102,35,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6v   $	��184��6�   .��6�   ��5      �� 5      	 �� Path$	 Id�6   
 �� UpdateSourceTrigger$
 PropertyChanged=�6$    �� ValidationRules 5      5      .��5       =� ErrorTemplate 5       �� 5!      .R�5"      �  � RowDefinitions 5#      �� 5$       5&      �� 5'      �� 5(      $
��Auto �6/   .+�5+      ��  ��Name$ textBox��6Q   $��0��64   $��0��6D   6Q   �� 5,      $��1��6$   $��0��64   
���  ��$	��Top=�6t   $��22(�6�   $��Medium"�6�   ��6A   �� *[0].ErrorContent+6�   5-      5.      .��5/   (   51      �� 52   
   -   5        $ ime_textBox��52      $
��Left=�6I   $��23��6d   $��
103,68,0,0q�6p   $
 Wrap=�6�   $	��Top=�6�   $	��184��6�   ��6'   �� *Ime+ �� Mode$ TwoWay=�6�   �� 53   
   -   5        $ prezime_textBox��53      $
��Left=�6Q   $��23��6l   $��
102,99,0,0q�6x   $
 Wrap=�6�   $	��Top=�6�   $	��184��6�   ��6+   �� *	Prezime+$ TwoWay=�6�   �� 55   
   -   5        $ brojTelefona_textBox��55      $
��Left=�6[   $��23��6v   $��103,130,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��184��6�   ��60   �� *BrojTelefona+$ TwoWay=�6�   �� 58   
   -   5         ��Name$ sacuvaj��58      $��Sacuvaj��6"   $
��Left=�64   $��102,267,0,0q�6O   $	��Top=�6d   $��75��6|   6�   �� 59   
   -   5        $��Odustani��59      $
��Left=�6$   $��212,267,0,0q�6?   $	��Top=�6T   $��75��6l   6w   5<      5=      