   M S B A M L   `   `   `  ����?  ;Lab2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab2Lab2  5   	       Lab2.RegistroCamiones   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Lab2     5   	     � Title$  RegistroCamiones��5   	   $	��450��6"   $	��800��6/   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   .+�5   
   �� $��Peso Máximo:��6   $��0��6(   $��0��65   $��5q�6E   �� 5   
   -   5        $��PesoMaximoTextBox��5      $��0��6+   $��1��68   $��5q�6H   �� 5   
   $��Placa:��6   $��1��6"   $��0��6/   $��5q�6?   �� 5   
   -   5        $��PlacaTextBox��5      $��1��6&   $��1��63   $��5q�6C   �� 5   
   $��Peso Vacío:��6   $��2��6'   $��0��64   $��5q�6D   �� 5   
   -   5        $��PesoVacioTextBox��5      $��2��6*   $��1��67   $��5q�6G   �� 5!   
    �� Orientation$ 
Horizontal=�6   $��3��6.   $��2��6;   $��Center=�6O   $��30q�6l   .+�5"      �� $��Guardar��6   $��75��6'   $��5q�62   �� 5#      $��Cancelar��6   $��75��6(   $��5q�63   �� 5$      -   5        $��Lista��5$      $��75��6%   $��5q�60   6;   5%      5&      5'      