   M S B A M L   `   `   `  ����\  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35 "  Brush_DataGridHeaderBackground  �� 
StartPoint �� EndPoint � Color � Offset + 'Brush_DataGridHeaderMouseOverBackground  Brush_DataGridHeaderBorder $  Brush_DataGridHeaderSortedBorder ( $Brush_DataGridHeaderSortedBackground  Brush_DataGridSelected $  Brush_DataGridSelectedForeground �� Color " Brush_DataGridAltRowBackground  Style_HeaderGripper �� 
TargetType �� Property �� Value �� 
TargetType	 �� Padding=    7System.Windows.Controls.Primitives.DataGridColumnHeader
 � ColumnDefinitions ��Name F�Name �� Stretch J� RenderTransformOrigin n�Name �� Triggers P� Value P� Property �� 
TargetName �� Angle*   $System.Windows.Controls.DataGridCell)   #System.Windows.Controls.DataGridRow J� SnapsToDevicePixels?   9System.Windows.Controls.Primitives.SelectiveScrollingGrid  Name � RowDefinitions?   9System.Windows.Controls.Primitives.DataGridCellsPresenter  Name   
ItemsPanel:   4System.Windows.Controls.Primitives.DataGridRowHeader  Name$   SelectiveScrollingOrientation �� RelativeSource �� AncestorType&    System.Windows.Controls.DataGrid �� Path!   HeadersVisibilityConverter  �� 	Converter7   1System.Windows.Controls.DataGridHeadersVisibility
!   Row" �� ConverterParameterA   ;System.Windows.Controls.Primitives.DataGridDetailsPresenter#  Name 	 
BlueWindow$   SelectAllCommand% � OverridesDefaultStyleG	   ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter&   Column' �� CanContentScroll( �� Orientation) �� ScrollableHeight* � Maximum+ �� ViewportHeight, �� ViewportSize*- �� #ComputedVerticalScrollBarVisibility. � Value/ �� Mode0 �� ScrollableWidth1 �� ViewportWidth,2 �� %ComputedHorizontalScrollBarVisibility.
  (System.Windows.Interactivity.Interaction3 
  	BehaviorsA  ;Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorE  ?Microsoft.Expression.Interactivity.Layout.FluidMoveBehaviorBase4   	AppliesTo5 �� Triggers 
 ItemsPanelTemplate1�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      5      4dg-http://schemas.microsoft.com/wpf/2008/toolkit  5      Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      Bei9http://schemas.microsoft.com/expression/2010/interactions  6F   %H  &	        &	 �     &	 0    &	 �    &	 \    &	 �    &	     &	 �    &	 @    '   R    7  7  7  7  7  7  '  �    '  d    7  '  �    7  7   7  7   7  &	
 ,    �� 5      $	  0,0&�6A   $	 0,1&�6R   .��5   
   � $ 	#FF1C7CB1��6   $ 0Q�6)   � 5	   
   $ 	#FF004A83��6   $ 1Q�6)   5
      �� 5      $	  0,0&�6J   $	 0,1&�6[   .��5   
   � $ 	#FF1C7CAF��6   $ 0Q�6)   � 5   
   $ 	#FF042A68��6   $ 1Q�6)   5      �� 5      $	  0,0&�6=   $	 0,1&�6N   .��5   
   � $ 	#FF1B577E��6   $ 0Q�6)   � 5   
   $ 	#FF083258��6   $ 1Q�6)   5      �� 5      $	  0,0&�6C   $	 0,1&�6T   .��5   
   � $ #B58801��6   $ 0Q�6'   � 5   
   $ #681900��6   $ 1Q�6'   5      �� 5      $	  0,0&�6G   $	 0,1&�6X   .��5   
   � $ #C46007��6   $ 0Q�6'   � 5   
   $ #AF2600��6   $ 1Q�6'   5      �� 5       $ 0.5,1&�69   $  0.5,0&�6J   .��5!   
   � $ 	#FF3E4854��6   $ 1Q�6)   � 5"   
   $ 	#FF5D6670��6   5#      �� 5%      $ #FFFFFF��6?   �� 5'      $ 0.5,1&�6A   $  0.5,0&�6R   .��5(   
   � $ 	#FFE1FFEE��6   $ 0Q�6)   � 5)   
   $ 	#FFC3F9DA��6   $ 0.992Q�6)   5*      �� 5,      " n�6(   .�5-   
   ��  � ��$ 8��6"   �� 5.   
    � ��
 ���� 6'   �� 5/   
    �@�Cursor$ SizeWE��6#   �� 50   
    � �� 51      �� 52      " n�6"   .R�53      �� #	 z��6   #��z��6A   54      56      57      �� 59      "   6   .�5:   
   ��  �@J�SnapsToDevicePixels . 60   �� 5;   
    � ��$ 0��6%   �� 5<   
    � ��$ 28��6&   �� 5=   
    � ��
 �����6'   �� 5>   
    �@�Cursor$
 Hand��6#   �� 5?   
    � �� 5@      �� 5A      "   6"   .R�5B      � 
 5C      �� 5D      $��* �6/   �� 5E      $
��Auto �6/   .+�5G      �� $ BackgroundBorder��6!   $��0,1,0,1q�6;   8��  8�� $��2��6�   �� 5H      $��6,3,6,3q�6+   $��Center=�6<   F� 5I      $ 	SortArrow��6   $y�	Collapsed=�62   "����        �@B     � � @B 	$
 Fill=�6b   $��1��6q   $��8��6�   $��6��6�   
�������$��0,0,8,0q�6�   $��Center=�6�   $ 0.5,0.4&�6�   �� 5J      $��1��6$   ���#AAC377$��Right=�6=   $��2��6Y   �� 5K      $��1��6$   $��0,0,1,0q�6.   ���#425B10$��Right=�6N   $��2��6j   n� 5L      $ PART_LeftHeaderGripper��6    $
��Left=�6@   8�� 6[   n� 5M      $ PART_RightHeaderGripper��6    $��Right=�6A   8�� 6]   5N       5O      P� 5P       6;   Z�  �@  SortDirection. �5Q      �� $ BackgroundBorder��6%    � ��
 ���� 6Y   �� 5R      $ BackgroundBorder��6%    � ��
 ���� 6[   5S      P� 5T       �@J�IsMouseOver . . �5U      �� $ BackgroundBorder��6%   8   � ��6Y   �� 5V      $ BackgroundBorder��6%   8   � ��6Z   5W      P� 5X       �@  SortDirection$ 	AscendingX�6;   . �5Y      �� $ 	SortArrow��6%    � y�$ Visible=�6R   �� 5Z      $ 	SortArrow��6%    � z� 5[   "   �� 5\   &   $	 180Q�66   5^      5_      P� 5`       �@  SortDirection$ 
DescendingX�6;   . �5a      �� $ 	SortArrow��6%    � y�$ Visible=�6R   5b      P� 5c       �@  DisplayIndex$ 0��6:   . �5d      �� $ PART_LeftHeaderGripper��6M    � y�$ 	Collapsed=�6;   6s   5e      5g      5i      5j      �� 5n      "  6   .�5o   
   ��  �@�OverridesDefaultStyle . 62   �� 5p   
    � ��
 �   �6'   �� 5q   
    � �� 5s      �� 5t      "  6"   .R�5u      �� $ BackgroundBorder��6   
������ ._�5v      �� $��Center=�6+   $��4,0,6,0q�6F   5w      5x      5z      �� 5{   
    � �� 6(   Z� 5|      �� 5�      "  6)   .�5�   
   ��  � ��# � ��6'   �� 5�   
    �@J�SnapsToDevicePixels . 60   �� 5�   
    � �� 5�      �� 5�      "  6"   .R�5�      �� $ 
DGR_Border��5�      #��z��5�      #��z��5�      #��z��5�       . ._�5�        $ selectiveScrollingGrid��61   
 5�      �� 5�   "   $
��Auto �63   �� 5�   "   $��* �63    5�      �� 5�   "   $
��Auto �60   �� 5�   "   $
��Auto �60   .+�5�        $ dataGridCellsPresenter��65   $��1��5�      #��z 5�      # z 5�        5�      $ dataGridRowHeader��60   $ Vertical=�5�      $��2��5�      y�5�      ��  �� "  $ HeadersVisibility�#  Z #" Z! � 5�      $��Details��6@   $��1��6#   $��1��63   $y�	Collapsed=�6O   
�������.+�5�   "     $# dataGridDetailsPresenter��6;   5�      5�      5�       5�      P� 5�       �@J�IsMouseOver . . �5�      �� $ 
DGR_Border��6;   # � 	 6S    � ���� 5�      $ dataGridCellsPresenter��6;    � ��
 �����6_   �� 5�      $ dataGridRowHeader��6;    � ��
 �����6Z   �� 5�      $ dataGridRowHeader��69    � ��$ 13.333(�6X   5�      P� 5�       �@ 
IsSelected . . �5�      �� $ 
DGR_Border��6%   8    � ��6_   �� 5�      $ dataGridDetailsPresenter��6;    � y�$ Hidden=�6a   �� 5�      $ dataGridCellsPresenter��69    � ��$ 14.667(�6]   �� 5�      $ 
DGR_Border��6;    � ��
 � ���6S   5�      5�      5�      5�      �� 5�      "  6&   .�5�   
   ��  � �� . 6:   �� 5�   
    �@J�SnapsToDevicePixels . 60   �� 5�   
     �@ AlternatingRowBackground8   65   �� 5�   
    � �� 5�      �� 5�      "  6"   .R�5�      �� #��z��6   ._�5�      �� $��DG_ScrollViewer��69   |�.  ��5�      �� 5�   "   " ��62   .R�5�   &   �  5�   *   �� 5�   .   $
��Auto �6<   �� 5�   .   $��* �6<   �� 5�   .   $
��Auto �6<   
 5�   *   �� 5�   .   $
��Auto �6?   �� 5�   .   $��* �6?   �� 5�   .   $
��Auto �6?   .+�5�   *   �� $��3��61   8�� 8�� $	��0,1q�6�   �� 5�   *   #��Z$ 5�      |�.  % . ��5�      ��  �� "  $ RowHeaderActualWidth���5�   .   �� 5�   2   " ��6B   .R�5�   6   � .+�5�   :   �� 8�� 8�� $	��0,1q�6�   ._�5�   >   F� $ Arrow��6C   $��Bottom=�6R   $��4q�6m   ���#3000$��11��6�   $��11��6�   $
 Fill=�6�   "����@B     �@B @B �    @B 	6�   5�   ;   �� 5�   :   $��1��6D   ���#AAC377$��Right=�6]   �� 5�   :   $��1��6D   $��0,0,1,0q�6N   ���#425B10$��Right=�6n   5�   7   5�   3   5�   +   	  5�   *   $��1��5�      y�5�      ��  �� "  $ HeadersVisibility�#  Z #" Z& �� 5�   *   $��1��6A   $��2��6N   #' z��6b   �� 5�   *   $��PART_VerticalScrollBar��5�      $��1��5�      $��2��5�      $( Vertical=�5�      #* z) 5�      #, z+ 5�      #y�z- 5�      . 5�      �� $ VerticalOffset� �� *TemplatedParent+$/ OneWay=�5�      � 5�   *   $��2��6/   $��1��6<   
 5�   .   �� 5�   2   ��6C   ��  �� "  $. (NonFrozenColumnsViewportHorizontalOffset��� 5�   2   $��* �6C   .+�5�   .   �� $��PART_HorizontalScrollBar��5�      $��1��5�      $( 
Horizontal=�5�      #* z0 5�      #, z1 5�      #y�z2 5�      . 5�      �� $ HorizontalOffset� �� *TemplatedParent+$/ OneWay=�5�      5�   +   5�   '   5�   #   .��5     �� # z 6-   3 5  "     5  &   $4 Children=�6;   5     5     5     5	     5     5 5  
   P� 5      �@��
IsGrouping . . �5     ��  � �� .  6B   5     5     �� 5     .R�5  
   $� 3 5       5     $4 Children=�6'   5     5     5     