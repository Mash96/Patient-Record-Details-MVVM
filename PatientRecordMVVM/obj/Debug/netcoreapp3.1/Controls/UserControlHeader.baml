   M S B A M L   `   `   `  ����L  HPatientRecordMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:PatientRecordMVVM.ControlsPatientRecordMVVM.Controls  5      I)clr-namespace:PatientRecordMVVM.UtilitiesPatientRecordMVVM.Utilities  5      2    ,PatientRecordMVVM.Controls.UserControlHeader   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:PatientRecordMVVM.Controls     5      >language)clr-namespace:PatientRecordMVVM.Utilities     5      
�������.��5      �   � ColumnDefinitions  5   
   �� 5      $
��2.5* �6   �� 5      $��3* �6   �� 5      $
��2.5* �6    � RowDefinitions 5   
   �� 5      $
��1.5* �6   �� 5      $
��1.5* �6   .+�5   
   � $��2��6   $��3��6    ���#58af9d64   �� 5   
   $��2��6      StackpanelStyle#��[  6)   .+�5      �� $��16(�6@   $��Normal"�6N   
���������6   7   1PatientRecordMVVM.Utilities.LocalizationExtension  *	PatientId+6b   �� 5      $��16(�6;   
�������$	��5,0q�6\   ��6   ��  �� Path$ GuidGenerator�6\   5      �� 5    
   $��3��6   #��[  6+   $��Right=�6T   .+�5!      �� $��16(�6;   $��Normal"�6I   
���������6     *Date+6]   �� 5"      -   5        $��	date_time��5"      $��16(�6J   
�������$	��5,0q�6k   ��6%   �� $ CurrentDate�6k   5#      �� 5&   
   $��1��6=   $��3��6J   $��20(�6^   $��Normal"�6l   
�������$��Center=�6�   $��Center=�6�   $	��200��6�   ��6     *	MainTitle+6�   5'      5(      