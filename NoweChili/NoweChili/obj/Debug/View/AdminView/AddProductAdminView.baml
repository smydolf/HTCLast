   M S B A M L   `   `   `  ����D  @NoweChili, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:NoweChili.ViewNoweChili.View  5   	   (    "NoweChili.View.AddProductAdminView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:NoweChili.View     5   	   
�������  � Title$  Dodaj Produkt��5
   	   $	��600��6   $	��800��6,    � 
ResizeMode$ 	CanResize=�68   .��5      � $��7q�6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��* �6   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $��1* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��5* �6   �� 5      $��2* �6   .+�5    
   �� $��1��6   $��1��6%   .+�5!      �� $��Nazwa produktu��6   $
��Left=�6-   6J   �� 5"      -   5         ��Name$ NameOfProductTextBox��5"      $
��Auto��64   $
��Auto��6B   5#      �� 5$   
   $��1��6   $��3��6%   .+�5%      �� $��Kod produktu��6   $
��Left=�6+   6H   �� 5&      -   5        $ ProductCodeTextBox��5&      $
��Auto��62   $
��Auto��6@   5'      �� 5(   
   $��1��6   $��5��6%   .+�5)      �� $��Rozmiar produktu��6   $
��Left=�6/   6L   �� 5*      -   5        $ SizeOfProductTextBox��5*      $
��Auto��64   $
��Auto��6B   5+      �� 5,   
   $��1��6   $��7��6%   .+�5-      �� $��Cena produktu��6   $
��Left=�6,   6I   �� 5.      -   5        $ PriceOfProductTextBox��5.      $
��Auto��65   $
��Auto��6C   5/      � 50   
   $��8��6   $��1��6    51      �� 52      $��* �6    �� 53      $��* �6     55      �� 56      $
��0.5* �6#   �� 57      $��0.05* �6#   �� 58      $
��0.5* �6#   �� 59      $
��0.5* �6#   .+�5;      �� -   5         ��Name$ 
BackButton��5;      $��Cofnij��6)   6W   �� 5<      -   5        $ SubmitAddProduct��5<      $��
Zatwierdź��6/   $��2��6C   
������6�   5=      5>      5?      