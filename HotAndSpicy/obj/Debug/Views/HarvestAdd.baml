   M S B A M L   `   `   `  ����F  BHotAndSpicy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:HotAndSpicy.ViewsHotAndSpicy.Views  5   	   "    HotAndSpicy.Views.HarvestAdd   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:HotAndSpicy.Views     5   	     � Title$  
HarvestAdd��5   	   $	��300��6   $	��300��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $	��100 �6   �� 5       � RowDefinitions 5   
   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��35 �6   �� 5      $��35 �6   .+�5   
   �� $��0��6   $��RefID:��6   $��Center=�6/   $��Right=�6Q   �� 5   
   $��0��6   $��2��6    $��0,5,5,5q�6J   ��60   �� *
getrefId+6J   �� 5   
   $��1��6   $��Amount:��6   $��Center=�60   $��Right=�6R   �� 5   
   $��1��6   $��2��6    $��0,5,5,5q�6K   ��60   �� *	getamount+6K   �� 5   
   $��2��6   $��Erntedatum:��6   $��Center=�64   $��Right=�6V   �� 5   
   $��2��6   $��2��6    $��0,5,5,5q�6I   ��60   �� *	getdate+6I   �� 5!   
   $��5��6   $��2��6"    �� Orientation$ 
Horizontal=�66   $��
0,31,0,-31q�6O   .+�5"      �� $��OK��6   $	��100��6"   $��5q�6.   ��69   �� *	OkCommand+�� 5#      $��	Abbrechen��6   $	��100��6)   $��5q�65   ��6@   �� *CancelCommand+5$      5%      5&      