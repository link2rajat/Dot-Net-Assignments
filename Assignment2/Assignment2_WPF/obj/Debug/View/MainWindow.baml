   M S B A M L   `   `   `  ����  Assignment2_WPF     Assignment2_WPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   h dMicrosoft.Expression.Interactions, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bei9http://schemas.microsoft.com/expression/2010/interactions  6N     � Title$  
MainWindow��5   	   $��396.053��6   $��586.842��6-    � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5	      $* $../Resources/ResourceDictionary.xaml?�6%   %    5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dataGridServices��5       $��0��6      AutoGenerateColumns .     MinColumnWidth$ 15Q�5   /      CanUserAddRows .     SelectionMode$ Single=�6Z   $
��Auto=�6q   $��10,107,10,10q�5   Z      ItemsPanelTemplate1#���   6p   ��6   �� *
SortedList+	 �� UpdateSourceTrigger$	 PropertyChanged=�.  (System.Windows.Interactivity.Interaction
   	Behaviors
 5      A  ;Microsoft.Expression.Interactivity.Layout.FluidMoveBehavior  5         Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   MinWidth$ 80Q�6)      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 67      Header$ Employee's LASTNAME��6A      CanUserSort .    SortMemberPath$ LastName��6q      CellTemplate 5      �� 5      .R�5      � $
��Auto=�6#   .+�5   "   �� $��27��6,   $
��Auto��6v   ��68   �� *
LastName+$	 PropertyChanged=�5   #   5      5      5        5       $ 80Q�6)   $ * 67   $ Employee's PAY AMOUNT��6A    . $ PaymentAmount��6s    5!      �� 5"      .R�5#      � $
��Auto=�6#   .+�5$   "   �� $��27��6,   $
��Auto��6�   ��68   ��  �� Path$ PaymentAmount� �� StringFormat$ {0:C}��$	 PropertyChanged=�5%   #   5&      5'      5)        5*      $ 80Q�6)   $ * 67   $ Employee's SSN��6A    . $ SocialSecurityNumber��6l    5+      �� 5,      .R�5-      � $
��Auto=�6#   .+�5.   "   �� $��27��6,   $
��Auto��6�   ��68   �� *SocialSecurityNumber+$	 PropertyChanged=�5/   #   50      51      53      55      �� 56   
   $!��      Sort byLastname(ASC)��67   $
��Left=�6a   $��	10,17,0,0q�6|   $	��Top=�6�   $��87��6�   ��6   �� *SortByLastNameASC+6�   �� 57   
   $��    Sort byPayAmount��69   $
��Left=�6]   $��
102,17,0,0q�6x   $	��Top=�6�   $��92��6�   ��6   �� *SortByPayAmountDesc+6�   �� 58   
   $ ��    Sort by
SSN (Delegate)��65   $
��Left=�6^   $��
199,17,0,0q�6y   $	��Top=�6�   $��90��6�   ��6   �� *SortBySSNDelASC+6�   �� 59   
   $��Reset/Reload List��6/   $��Right=�6K   $��	0,71,10,0q�6g   $	��113��6z   $	��Top=�6�   $��31��6�   ��6   �� *	ResetGrid+6�   �� 5:   
   $��
Employees:��6   $
��Left=�6%   $��	10,77,0,0q�6@   $	��Top=�6S   $��25��6k   $��99��6w   �� 5;   
    �� DisplayMemberPath$	 Key��6    �� SelectedValuePath$ Value��5<      $
��Left=�5?      $��
450,33,0,0q�6(   $	��Top=�6<   $	��102��6T   $��32��6`   ��5=      �� *SortingList+ �� SelectedValue 5>      �� *SelectedSorting+ �� ValidatesOnDataErrors .  �� Mode$ TwoWay=�5?   `   �� 5@   
   $��Sorting Order:��6   $
��Left=�6)   $��	456,7,0,0q�6D   $	��Top=�6W   $��26��6o   $	��104��6{   5A      5B      