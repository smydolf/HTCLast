   M S B A M L   `   `   `  ����D  @NoweChili, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:NoweChili.ViewNoweChili.View  5   	   &     NoweChili.View.GeneralAdminPanel   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:NoweChili.View     5   	     � Title$$  Główny Panel Administracyjny��5   	   $	��600��6.   $	��800��6;    � 
ResizeMode$ 	CanResize=�6G   ��5	      �� 5
   
    �� ImageSource$ /Pictures/Pizza.jpg��6   .��5      � $��7q�6    � RowDefinitions 5   
   �� 5      $��2* �6   �� 5      $��* �6   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $��2* �6    � ColumnDefinitions 5   
   �� 5      $��2* �6   �� 5      $��* �6   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $
��0.2* �6   �� 5      $��* �6   �� 5      $��2* �6   .+�5   
   �� -   5         ��Name$ AddButtonInAdminPanel��5      $��1��60   $��1��6=   $��Dodaj produkt��6M    J� OpacityMask �	#E5F0C815���	#FFE448256�   �� 5   
   -   5        $# EditProductButtonInAdminPanel��5      $��1��68   $��3��6E   $��Edytuj produkt��6U    �	#E5F0C815���	#FFE448256�   �� 5   
   -   5        $ AddUserButtonInAdminPanel��5      $��1��64   $��5��6A   $��Dodaj użytkownika��6Q    �	#E5F0C815���	#FFE448256�   �� 5    
   -   5        $ OrderEditInAdminPanel��5       $��3��60   $��1��6=   $��Edytuj zamówienia��6M    �	#E5F0C815���	#FFE448256�   �� 5!   
   -   5        $$ AddTransportButtonInAdminPanel��5!      $��3��69   $��3��6F   $��Dodaj Dojazd��6V    �	#E5F0C815���	#FFE448256�   �� 5"   
   -   5        $ EditTransportInAdminPanel��5"      $��3��64   $��5��6A   $��Edytuj Dojazd��6Q    �	#E5F0C815���	#FFE448256�   �� 5#   
   -   5        $ Logout��5#      $��Button��6!   $
��Left=�62   $��
84,102,0,0q�6M   $��4��6a   $	��Top=�6n   $��75��6�   6�   5$      5%      