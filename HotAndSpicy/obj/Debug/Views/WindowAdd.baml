   M S B A M L   `   `   `  ����F  BHotAndSpicy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:HotAndSpicyHotAndSpicy  5   	       HotAndSpicy.WindowAdd   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:HotAndSpicy     5   	     � Title$  	WindowAdd��5   	   $	��300��6   $	��300��6(   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��100 �6   �� 5       � RowDefinitions 5   
   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��35 �6   .+�5   
   �� $��0��6   $��Name:��6   $��Center=�6.   $��Right=�6P   �� 5   
   $��0��6   $��2��6    $��0,5,5,5q�6F   ��60   �� *name+6F   �� 5   
   $��1��6   $��Sowing Month:��6   $��Center=�66   $��Right=�6X   �� 5   
   $��1��62   $��2��6?   $��0,5,5,5q�6t   ��6   �� *months+ �� SelectedItem 6O   �� *sowingMonth+5      �� 5   
   $��2��6   $��Severity Level:��6   $��Center=�68   $��Right=�6Z   �� 5    
   $��2��6   $��2��6    $��0,5,5,5q�6O   ��60   �� *severityLevel+6O   �� 5"   
   $��3��6   $��Outdoor After:��6   $��Center=�67   $��Right=�6Y   �� 5#   
   $��3��6   $��2��6    $��0,5,5,5q�6N   ��60   �� *outdoorAfter+6N   �� 5%   
   $��4��6   $��Hybrid Seed:��6   $��Center=�65   $��Right=�6W   �� 5&   
   $��4��6   $��2��6    $��0,5,5,5q�6s    60   �� *
hybridSeed+��6T   �� *hybrid+5'      �� 5)   
   $��5��6   $��2��6"    �� Orientation$ 
Horizontal=�66   $��
0,31,0,-31q�6O   .+�5*      �� $��OK��6   $	��100��6"   $��5q�6.   ��69   �� *	OkCommand+�� 5+      $��	Abbrechen��6   $	��100��6)   $��5q�65   ��6@   �� *CancelCommand+5,      5.      5/      