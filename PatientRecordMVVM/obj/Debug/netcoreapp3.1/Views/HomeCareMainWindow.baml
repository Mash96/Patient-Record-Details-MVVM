   M S B A M L   `   `   `  ����L  HPatientRecordMVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:PatientRecordMVVM.ViewsPatientRecordMVVM.Views  5   	   K*clr-namespace:PatientRecordMVVM.ViewModelsPatientRecordMVVM.ViewModels  5	   	   G(clr-namespace:PatientRecordMVVM.ControlsPatientRecordMVVM.Controls  5
   	   I)clr-namespace:PatientRecordMVVM.UtilitiesPatientRecordMVVM.Utilities  5   	   0    *PatientRecordMVVM.Views.HomeCareMainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   1local%clr-namespace:PatientRecordMVVM.Views  5   	   3vm*clr-namespace:PatientRecordMVVM.ViewModels  5	   	   7controls(clr-namespace:PatientRecordMVVM.Controls  5
   	   8language)clr-namespace:PatientRecordMVVM.Utilities  5   	   $	��850��5   	   $
��1500��6   
���������5   	   :  4MaterialDesignThemes.Wpf.MaterialDesignFontExtension    � DataContext  5      8  2PatientRecordMVVM.ViewModels.HomeCareMainViewModel  5   
    � 	Resources 5       �� DataTypeC  =PatientRecordMVVM.ViewModels.AddPatientRecordDetailsViewModel<   6PatientRecordMVVM.Views.AddPatientRecordDetailsControl   MenuOpen �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  	MenuClose��%G  (��       5      *, +)&	  .     &	 �    �� 6
   "  6   .R�5        5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridSideMenu��6a   .\�5        $ 0��6'   $ 60Q�63     5      $ 0:0:0:0��6'   $	 210Q�69   5      U� 5      $ (FrameworkElement.Width)�6,   $ 
ListButton��6a   .\�5        $ 0��6'   $ 60Q�63     5       $ 0:0:0:0��6'   $	 190Q�69   5!      5"      �� 5$   
   .��5%      U� $ (FrameworkElement.Width)�6,   $ GridSideMenu��6a   .\�5&        $ 0��6'   $	 210Q�63     5'      $ 0:0:0:0��6'   $ 60Q�69   5(      U� 5*      $ (FrameworkElement.Width)�6,   $ 
ListButton��6a   .\�5+        $ 0��6'   $	 190Q�63     5,      $ 0:0:0:0��6'   $ 60Q�69   5-      5.      5/       � Triggers 51      :� 52   
    :� RoutedEvent$ ButtonBase.Click��6   	 :� 
SourceName$	 ButtonOpenMenu��66   .[�53      �� #��[  6   54      :� 55   
   $ ButtonBase.Click��6   $	 ButtonCloseMenu��66   .[�56      �� #��[ 6   57      .��5:      � 
 � ColumnDefinitions
 5;   
   �� 5<      $
��2.6* �6   �� 5=      $��3* �6   �� 5>      $	��13* �6    � RowDefinitions 5A   
   �� 5B      $��2* �6   �� 5C      $	��20* �6   .+�5F   
   �� -   5         ��Name$
 Logo��5F      $��1��6   $��2��6+   $2��,/PatientRecordMVVM;component/Images/logo.jpg��6<    J� Opacity$
 0.12Q�6r   $��Center=�6�   $��Center=�6�   � 5G   
   $��0��6   $��3��6   .+�5H      2   ,PatientRecordMVVM.Controls.MainHeaderControl  5I      � 5K   
   -   5         �Name$ GridSideMenu��5K      $��2��6%   $��0��66     
GridShadow#��[ 6F   $
��Left=�6j   ���#1A365D$	��210��6�   .+�5L      ��  �� Orientation$ Vertical=�6   .+�5M      � 
�������$	��150��6*   $	��Top=�67   .+�5N      �� -   5        $ SideLogo��5N      $2��,/PatientRecordMVVM;component/Images/logo.jpg��6.   $��Center=�6d   $��Center=�6�   �� 5O      -   5         ��Name$ ButtonCloseMenu��5O      ���#1A365D$��60��6x   $��60��6�   $��Right=�6�   $	��Top=�6�   $y�	Collapsed=�6�   ��66   Z� ��6L   Z� .��5P      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�62   $��25��6C   $��25��6N   5Q      �� 5R      -   5        $ ButtonOpenMenu��5R      ���#1A365D$��60��6w   $��60��6�   $��Right=�6�   $	��Top=�6�   ��65   Z� ��6K   Z� .��5S        $
 Menu=�62   $��25��6>   $��25��6I   5T      5U      �� 5V      
�������$��Disabled=�6.   $��0,50,0,0q�6d   .@�5W      �� $��60��6#   $��Center=�6/   .��5X      �� -   5        $ 
ListButton��5X   !    # MaterialDesignRaisedLightButton#���  6`   
����������#58af9d���#58af9d$	��190��6�   $��40��6�   $	��Top=�6�   ��65   ��  �� Path$ AddPatientCommand�.��5Y      �� $ 
Horizontal=�6)   $��Center=�6B   .+�5Z   "     $	 Add=�6:   
�������$��25��6X   $��25��6c   $
��Left=�6o   $��Center=�6�   $��-5,0,9,0q�6�   �� 5[   "   $��12(�6V   $��Center=�6d   ��6,   7   1PatientRecordMVVM.Utilities.LocalizationExtension  *
AddPatient+6d   5\      5]      5^      5_      5`      5a      � 5c   
   -   5        $ GridCard��5c      $��1��6!   $��1��6.   $��1��6B   $��Center=�6R   .+�5d      #	  MaterialDesignThemes.Wpf.Card	  $��Center=�6"   $��Center=�6?   
�������$	��210��6m   $	��730��6y   $
��0,10q�6�   .��5e      �� $ Vertical=�6   $��Center=�64   $��Stretch=�6Q   .+�5f      �� -   5        $ ButtonAnalytics��5f      $	��150��66   $	��150��6B   ���#CEE8EC���#CEE8EC$��	0,20,0,10q�6z   .��5g      �� $ Vertical=�6%   .+�5h        $ GoogleAnalytics=�66   ���#1A365D$��60��6b   $��60��6m   $��Center=�6y   $	��Top=�6�   �� 5i      $��16(�6Q   $��Medium"�6_   ���#1A365D$��0,20,0,0q�6�   ��6(     *	Analytics+6�   5j      5k      �� 5l      -	   5        $ ButtonReports��5l      $	��150��64   $	��150��6@   ���#CEE8EC���#CEE8EC$��	0,20,0,10q�6x   .��5m      �� $ Vertical=�6%   .+�5n        $
 Book=�66   ���#1A365D$��60��6W   $��60��6b   $��Center=�6n   $	��Top=�6�   �� 5o      $��16(�6O   $��Medium"�6]   ���#1A365D$��0,20,0,0q�6�   ��6(     *	Reports+6�   5p      5q      �� 5r      -
   5        $ ButtonEmployee��5r      $	��150��65   $	��150��6A   ���#CEE8EC���#CEE8EC$��	0,20,0,10q�6y   .��5s      �� $ Vertical=�6%   .+�5t        $ ClipboardList=�66   ���#1A365D$��60��6`   $��60��6k   $��Center=�6w   $	��Top=�6�   �� 5u      $��16(�6O   $��Medium"�6]   ���#1A365D$��0,20,0,0q�6�   ��6(     *	EmpList+6�   5v      5w      �� 5x      -   5        $ ButtonEquipments��5x      $	��150��67   $	��150��6C   ���#CEE8EC���#CEE8EC$��0,20,0,0q�6{   .��5y      �� $ Vertical=�6%   .+�5z        $ TestTube=�66   ���#1A365D$��60��6[   $��60��6f   $��Center=�6r   $	��Top=�6�   �� 5{      $��16(�6Q   $��Medium"�6_   ���#1A365D$��0,20,0,0q�6�   ��6(     *	EquipList+6�   5|      5}      5~      5      5�      � 5�   
   $��1��6   $��2��6   .+�5�      �� -   5         ��Name$ ContentDisplay��5�      $��Center=�5�      $	��800��5�      $	��730��5�      $��	20,0,20,0q�5�      ��5�      �� *SelectedViewModel+5�      5�      5�      5�      