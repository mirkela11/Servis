   M S B A M L   `   `   `  ����A  =Servis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Servis.DijaloziServis.Dijalozi  5   	       Servis.Dijalozi.vozila   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Servis.Dijalozi     5   	     � Title$  Dodaj vozilo��5   	   $��349.358��6   $��345.07��6/   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��73* �6   �� 5      $
��265* �6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color# � ��6    � Offset$ 1Q�6^   � 5      $ 	#FF2E17F9��6   5      .+�5   
   �� $��Marka vozila:��6   $
��Left=�6(   $��	24,31,0,0q�6C   $	��Top=�6V   $��2��6n   �� 5   
   $��Model vozila:��6   $
��Left=�6(   $��	26,70,0,0q�6C   $	��Top=�6V   $��2��6n   �� 5   
   $��Registarski broj:��6   $
��Left=�6,   $��
24,156,0,0q�6G   $	��Top=�6[   $��2��6s   �� 5   
   $��Broj sasije:��6   $
��Left=�6'   $��
24,108,0,0q�6B   $	��Top=�6V   $��2��6n   �� 5   
   -   5         ��Name$ markaVozila_textBox��5      $
��Left=�6M   $��23��6h   $��	40,31,0,0q�6t    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��203��6�   $��1��6�   ��6/   �� *MarkaVozila+6�   �� 5   
   -   5        $ modelVozila_textBox��5      $
��Left=�6L   $��23��6g   $��	40,71,0,0q�6s   $
 Wrap=�6�   $	��Top=�6�   $	��203��6�   $��1��6�   ��6/   �� *ModelVozila+6�   �� 5   
   -   5        $ regBroj_textBox��5      $
��Left=�6D   $��23��6_   $��40.2,159,0,0q�6k   $
 Wrap=�6�   $	��Top=�6�   $	��203��6�   $��1��6�   ��6+   �� *	RegBroj+6�   �� 5   
   -   5        $ brojSasije_textBox��5      $��23��6J   $��40.2,111,22.4,0q�6V   $
 Wrap=�6o   $	��Top=�6�   $��1��6�   ��6.   �� *
BrojSasije+6�   �� 5   
   -   5        $ tip_textBox��5   N   $
��Left=�6   $��23��6c   $��
22,203,0,0q�6o   $
 Wrap=�6�   $	��Top=�6�   $	��125��6�    � ToolTip$&  Obavezan unos tipa manifestacije��6�   $��1��6�   ��6-   �� *OznakaKorisnika+6�   �� 5   
   -   5        	 ��Name$	 sacuvaj��5      $��Sacuvaj��6"   $
��Left=�64   $��
52,284,0,0q�6O   $	��Top=�6c   $��75��6{   $��1��6�   �� 5   
   -   5        $��Odustani��5      $
��Left=�6$   $��168,284,0,0q�6?   $	��Top=�6T   $��75��6l   $��1��6�   �� 5   
   $	��Tip��6   $
��Left=�6   $��
26,201,0,0q�69   $	��Top=�6M   �� 5    
   -   5        $��Odabir korisnika��5       $
��Left=�6,   $��168,207,0,0q�6G   $	��Top=�6\   $��75��6t   $��1��6�   5"      5#      