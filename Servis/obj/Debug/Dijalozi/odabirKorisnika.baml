   M S B A M L   `   `   `  ����A  =Servis, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Servis.DijaloziServis.Dijalozi  5   	        Servis.Dijalozi.odabriTipa   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Servis.Dijalozi     5   	     � Title$  Odabir tipa��5   
   $	��400��6   $	��400��6+    � WindowStartupLocation$ CenterScreen=�67    � 
ResizeMode$ CanMinimize=�6\   .��5	      �  � ColumnDefinitions 5
   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dgrMain��5         
IsReadOnly .    AutoGenerateColumns .  $��0,0,-0.4,45.4q�6y   ��6$   ��  �� Path$ 	Korisnici���5      �� 5       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5      � 
 � Color#
 � ��6#    � Offset$ 1Q�6b   � 5      $
 	#FF2E17F9��6#   5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 2* 6H   1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *Id+6H     5      $	 Ime��6%   $ 4* 6J    62   �� *Ime+6J     5      $ Prezime��6%   $ 3* 6R    66   �� *	Prezime+5      5       �� 5!   
   -   5         ��Name$ izaberi��5!   #   $��Izaberi��6   $
��Left=�64   $��176,341,0,0q�6O   $	��Top=�6d   $��75��6|   6�   �� 5"   
   -   5        $��Odustani��5"      $
��Left=�6$   $��285,341,0,0q�6?   $	��Top=�6T   $��75��6l   6w   5%      5&      