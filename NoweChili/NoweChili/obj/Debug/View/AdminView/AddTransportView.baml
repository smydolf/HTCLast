   M S B A M L   `   `   `  ����D  @NoweChili, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:NoweChili.View.AdminViewNoweChili.View.AdminView  5   	   /    )NoweChili.View.AdminView.AddTransportView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:NoweChili.View.AdminView     5   	     � Title$  AddTransportView��5   	   $	��600��6"   $	��800��6/   .��5	      � $��7q�6    � RowDefinitions 5
   
   �� 5      $��1* �6   �� 5      $��* �6   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $��1* �6   �� 5      $��1* �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��5* �6   �� 5      $��2* �6   .+�5   
   �� $��1��6   $��2��6%   $��0,10,0,5q�62   $��2��6D   .+�5       �� $��Adres��6   $
��Left=�6$   6A   �� 5!      -   5         ��Name$ TransportNameTextBox��5!      $
��Auto��64   $
��Auto��6B   5"      �� 5#   
   $��1��6   $��5��6%   .+�5$      �� $��Cena transportu��6   $
��Left=�6.   6K   �� 5%      -   5        $ TransportPriceTextBox��5%      $
��Auto��65   $
��Auto��6C   5&      � 5(   
   $��7��6   $��1��6    5)      �� 5*      $��* �6    �� 5+      $��* �6     5-      �� 5.      $
��0.5* �6#   �� 5/      $��0.05* �6#   �� 50      $
��0.5* �6#   �� 51      $
��0.5* �6#   .+�53      �� -   5         ��Name$ 
BackButton��53      $��Cofnij��6)   6W   �� 54      -   5        $ SubmitAddUser��54      $��
Zatwierdź��6,   $��2��6@   
������6�   55      56      57      