   M S B A M L   `   `   `  ����?  ;Lab2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab2Lab2  5   	       Lab2.RegistroSalidas   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:Lab2     5   	     � Title$  RegistroSalidas��5   	   $	��450��6!   $	��800��6.   .��5	      � $��10q�6    � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   .+�5   
   �� $��Tipo de Documento:��6   $��0��6.   $��0��6;   $��5q�6K   �� 5   
   -   5        $��TipoDocumentoComboBox��5      $��0��60   $��1��6=   $��5q�6M   �� 5   
   $��Número de Documento:��6   $��1��60   $��0��6=   $��5q�6M   �� 5   
   -   5        $��NumeroDocumentoTextBox��5      $��1��60   $��1��6=   $��5q�6M   �� 5!   
   $��Peso:��6   $��2��6!   $��0��6.   $��5q�6>   �� 5"   
   -   5        $��PesoTextBox��5"      $��2��6%   $��1��62   $��5q�6B   �� 5$   
   $��Tipo de Auto:��6   $��3��6)   $��0��66   $��5q�6F   �� 5%   
   -   5        $��TipoAutoTextBox��5%      $��3��6)   $��1��66   $��5q�6F   �� 5'   
   $��Nombre del Transportista:��6   $��4��65   $��0��6B   $��5q�6R   �� 5(   
   -   5        $ ��NombreTransportistaTextBox��5(      $��4��64   $��1��6A   $��5q�6Q   �� 5*   
   $��Fecha y Hora:��6   $��5��6)   $��0��66   $��5q�6F   (  "System.Windows.Controls.DatePicker  5+   
   -   5        $��FechaPicker��5+      $��5��6(   $��1��65   $��5q�6E   �� 5-   
   $��Peso de Ingreso:��6   $��6��6,   $��0��69   $��5q�6I   �� 5.   
   -   5        $��PesoIngresoTextBox��5.      $��6��6,   $��1��69   $��5q�6I   �� 50   
   $��Peso de Salida:��6   $��7��6+   $��0��68   $��5q�6H   �� 51   
   -   5        $��PesoSalidaTextBox��51      $��7��6+   $��1��68   $��5q�6H   �� 53   
    �� Orientation$ 
Horizontal=�6   $��8��6.   $��2��6;   $��Center=�6O   $��30q�6l   .+�54      �� $��Guardar��6   $��75��6'   $��5q�62   �� 55      $��Cancelar��6   $��75��6(   $��5q�63   56      57      58      