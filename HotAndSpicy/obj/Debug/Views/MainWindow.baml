   M S B A M L   `   `   `  ����F  BHotAndSpicy, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:HotAndSpicyHotAndSpicy  5   	       HotAndSpicy.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:HotAndSpicy     5   	     � WindowStartupLocation$  Manual=�5   	    � Left$ 0��6(   
 � Top$ 0��61    � Title$ Hot And Spicy��5	   	   $	��672��6   $	��714��6,   .��5
      � $��	0,0,2,-20q�6    � ColumnDefinitions 5   
   �� 5      $
��158* �6   �� 5      $
��104* �6   �� 5      $	��81* �6   �� 5      $	��67* �6   �� 5      $
��204* �6   �� 5      $
��116* �6   .+�5   
   �� -   5         ��Name$ 
tabControl��5      $
��Left=�6)   $	��630��6D   $	��Top=�6Q   $	��696��6i   $��6��6u   .@�5      �� $��Chillisorten��6   .��5      � ���	#FFE5E5E5$��0,0,0,-5q�6.    � RowDefinitions 5      �� 5      �� 5      $��40 �6(   .+�5      �� $��0,0,0,10q�6d   ��6   �� *Chilis+ �� SelectedItem 6=   �� *SelectedChili+��5      �� 5      .R�5   "   �� $��0, 0, 0, 20q�6-   .+�5   &   �� ��60   �� *id+ �� StringFormat$ ID: {0}���� 5    &   ��60   �� *name+$ 	Name: {0}���� 5!   &   ��60   �� *sowingMonth+$ Aussaatdatum: {0}���� 5"   &   ��60   �� *severityLevel+$ Schärfegrad: {0}���� 5#   &   ��60   �� *outdoorsAfter+$ Outdoor ab: {0}���� 5$   &   ��60   �� *
hybridSeed+$ Hybrid Samen: {0}���� 5%   &   ��60   �� *inUse+$ Wird benutzt: {0}���� 5&   &   $�� ��60   5'   #   5(      5*      �� 5+      $��1��6!   	 �� Orientation$	 
Horizontal=�6.   .+�5,      �� $��Hinzufügen��6!   $��5q�66   $	��100��6A   ��6M   �� *
AddCommand+�� 5-      $��
Bearbeiten��6!   $��5q�66   $	��100��6A   ��6M   �� *EditCommand+�� 5.      $��	Entfernen��6!   $��5q�65   $	��100��6@   ��6L   �� *DeleteCommand+�� 5/      $��Diese Chili einpflanzen��6!   $��5q�6C   $	��152��6N   ��6Z   �� *Einpflanzen+�� 50      $��XML Importieren��6!   $��5q�6;   $	��152��6F   ��6R   �� *Import+51      52      53      �� 55      $��Eingepflanzte Chilis��6   .��56      � ���	#FFE5E5E5$��0,0,0,-5q�6.    57      �� 58      �� 59      $	��16* �6+   �� 5:      $	��20* �6+   �� 5;      $	��18* �6+   �� 5<      $
��577* �6+    5>      �� 5?      �� 5@      $��40 �6(   .+�5B      �� $��5��6d   ��6   �� *Plants+ 6=   �� *SelectedPlant+��5C      �� 5D      .R�5E   "   �� $��
0,0, 0, 20q�6-   .+�5F   &   �� ��60   �� *id+$ ID: {0}���� 5G   &   ��60   �� *refId+$ 
RefID: {0}���� 5H   &   ��60   �� *
sowingDate+$ Aussaatdatum: {0}���� 5I   &   ��60   �� *outdoorsDate+$ Outdoor ab: {0}���� 5J   &   ��60   �� *	comment+$ Kommentar: {0}��5K   #   5L      5N      �� 5O      $��1��6!   $	 
Horizontal=�6.   $��5��6G   .+�5P      �� $��	Entfernen��6!   $��5q�65   $	��100��6@   ��6L   �� *DeletePlant+�� 5Q      $��Ernten��6!   $��5q�62   $	��100��6=   
 J� RenderTransformOrigin$
 -10.35,0.567&�6k   ��6J   �� *HarvestPlant+6k   �� 5R      $��
Bearbeiten��6!   $��5q�66   $	��100��6A   ��6M   �� *	EditPlant+5S      5T      5U      �� 5W      $��Ernten��6   .��5X      � ���	#FFE5E5E5$��0,0,0,-5q�6.    5Y      �� 5Z      �� 5[      $��40 �6(   .+�5]      �� ��6   �� *	Harvest+ 6>   �� *SelectedHarvest+��5^      �� 5_      .R�5`   "   �� $��
0,0, 0, 20q�6-   .+�5a   &   �� ��60   �� *refId+$ 
RefID: {0}���� 5b   &   ��60   �� *date+$ Erntedatum: {0}���� 5c   &   ��60   �� *amount+$ 
Menge: {0}��5d   #   5e      5g      �� 5h      $��1��6!   $	 
Horizontal=�6.   .+�5i      �� $��
Bearbeiten��6!   $��5q�66   $	��100��6A   ��6M   �� *DeleteHarvest+5j      5k      5l      5m      5n      5o      