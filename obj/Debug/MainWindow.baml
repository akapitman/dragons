   M S B A M L   `   `   `  ����  DragonsList    DragonsList.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   a ]DevExpress.Xpf.Core.v15.2, Version=15.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5   	   f bDevExpress.Xpf.Grid.v15.2.Core, Version=15.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aa ]DevExpress.Xpf.Grid.v15.2, Version=15.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid   6G     � Title$  
MainWindow��5   	   $	��650��6   $	��925��6)   .��5      � .+�5   
   &   DevExpress.Xpf.Core.DXTabControl  .@�5	      #  DevExpress.Xpf.Core.DXTabItem  �  �DevExpress.Xpf.Core.Native.HeaderedSelectorItemBase`2[[DevExpress.Xpf.Core.DXTabControl, DevExpress.Xpf.Core.v15.2, Version=15.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a],[DevExpress.Xpf.Core.DXTabItem, DevExpress.Xpf.Core.v15.2, Version=15.2.9.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a]]   Header$ Fish and Wood��6   .��5
      � 
������  � ColumnDefinitions 5      �� 5      �� 5       � RowDefinitions 5      �� 5      $��35 �6(   66   �� 5      6*   .+�5      �� $
��Fish��6   $��0��6+   $��10(�6;   $��24��6I   $��Center=�6U   6t   �� 5      $
��Wood��6   $��1��6+   $��10(�6;   $��24��6I   $��Center=�6U   6t   %  DevExpress.Xpf.Grid.GridControl  5      -   5          Name$ gridFish��5   4   $��1��6&   $��0��6F   )  #DevExpress.Xpf.Grid.DataControlBase   AutoGenerateColumns$ AddNew=�6V   #   EnableSmartColumnsGeneration .    Columns 5      $  DevExpress.Xpf.Grid.GridColumn  5      $  DevExpress.Xpf.Grid.ColumnBase   	FieldName$
 Name��6-     5      	   	SortOrder$	 
Descending=�6-   $ Value��6D     5      $
 Type��6-   
   View
 5      #  DevExpress.Xpf.Grid.TableView  5         AllowPerPixelScrolling . &	   DevExpress.Xpf.Grid.DataViewBase 	  ShowTotalSummary . 6J   5         5!      -   5        $ gridWood��5!   4   $��1��6'   $��1��6G   $ AddNew=�6X    .  5"        5#      $
 Name��6-     5$      $	 
Descending=�6-   $ Value��6D     5%      $
 Type��6-   
 5'        5(       .  . 6J   5*      5-      5/        50      $
 Iron��6   .��51      � 
������  53      �� 54      �� 55       57      �� 58      $��35 �6(   66   �� 59      6*   .+�5;      �� $
��Fish��6   $��0��6+   $��10(�6;   $��24��6I   $��Center=�6U   6t   �� 5<      $
��Wood��6   $��1��6+   $��10(�6;   $��24��6I   $��Center=�6U   6t     5>      -   5        $ gridIronFish��5>   4   $��1��6&   $��0��6J   $ AddNew=�6Z    .  5?        5@      $
 Name��6-     5A      $	 	Ascending=�6-   $ Value��6C     5B      $
 Type��6-   
 5D        5E       .  . 6J   5G        5H      -   5        $ gridIronWood��5H   4   $��1��6'   $��1��6K   $ AddNew=�6\    .  5I        5J      $
 Name��6-     5K      $	 	Ascending=�6-   $ Value��6C     5L      $
 Type��6-   
 5N        5O       .  . 6J   5Q      5T      5V        5W      $ Battle��6   .��5X      � 
������  5Y      �� 5Z      �� 5[      �� 5\       5^      �� 5_      $��35 �6(   66   �� 5`      6*   .+�5b      �� $��Range��6   $��0��6,   $��10(�6<   $��24��6J   $��Center=�6V   6u   �� 5c      $��Attack��6   $��1��6-   $��10(�6=   $��24��6K   $��Center=�6W   6v   �� 5d      $��Defend��6   $��2��6-   $��10(�6=   $��24��6K   $��Center=�6W   6v     5f      -   5        $ battleRange��5f   4   $��1��6&   $��0��6I   $ AddNew=�6Y    .  5g        5h      $
 Name��6-     5i      $	 
Descending=�6-   $ Value��6D     5j      $
 Type��6-   
 5l        5m       .  . 6J   5o        5p      -   5        $ 	battleAtk��5p   4   $��1��6'   $��1��6H   $ AddNew=�6Y    .  5q        5r      $
 Name��6-     5s      $	 
Descending=�6-   $ Value��6D     5t      $
 Type��6-   
 5v        5w       .  . 6J   5y        5z      -   5        $ 	battleDef��5z   5   $��1��6'   $��2��6J   $ AddNew=�6Z    .  5{        5|      $
 Name��6-     5}      $	 
Descending=�6-   $ Value��6D     5~      $
 Type��6-   
 5�        5�       .  . 6J   5�      5�      5�      5�      5�      5�      