   M S B A M L   `   `   `  ����  BackgroundWorker_Sample(    "BackgroundWorker_Sample.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5	      $
��Auto �6   �� 5
      $
��Auto �6   .+�5   
   �� -   5         ��Name$ ListBox1��5      $��0��6   5      � 5   
   -   5         �Name$ ProgressBar1��5   #   $��1��6   $��20��69   $��5q�6E   �� 5   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��5q�6;   .+�5      �� $��Status: ��6   �� 5      -   5         ��Name$ StatusTextBox��5      5      � 5   
   $��3��6   $��10q�6    � ColumnDefinitions 5      �� 5      $��1* �6#   �� 5      $��1* �6#   .+�5      �� -   5         ��Name$ StartButton��5   %   $��0��6   $��Start��6:   6J   �� 5      -   5        $ CancelButton��5   %   $��1��6   $��Cancel��6;   $��10,0,0,0q�6g   5      5      5       