   M S B A M L   `   `   `  ����S  OTiny Kitchen Application, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Tiny_Kitchen_ApplicationTiny_Kitchen_Application  5   	   -    'Tiny_Kitchen_Application.CalendarWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:Tiny_Kitchen_Application     5   	     � Title$  CalendarWindow��5   	   $	��450��6    $	��700��6-   ���#3A6A59.��5
      �  � ColumnDefinitions 5   
   �� 5      $��0* �6   �� 5      .+�5   
   &   System.Windows.Controls.Calendar  -   5        $��calendar��5      $��10q�6#   ���#B9C8BC$
��Left=�6M   $��	10,40,0,0q�6h   $	��Top=�5         DisplayMode$ Month=�6%      FirstDayOfWeek$ Monday=�5         IsTodayHighlighted$
 True��6%   $	��218��5   B   $	��401��6O   $��2��6[      BlackoutDates 5      /  )System.Windows.Controls.CalendarDateRange  5         Start$ 4/2/2020��6$   
   End$ 4/5/2020��65      SelectedDates 5      5      �� 5   
   -   5        $��selectedDate��5      $��23��6&   $��118,258,398,0q�62   	 �� TextWrapping$
	 Wrap=�5      $��Date Selected: ��6!   $	��Top=�68   $��2��6P   �� 5   
   -   5        $��calendarNotes��5      $��411,40,17,35q�6'   $
	 Wrap=�6=   $��Notes: ��6Q   $��2��6`   �� 5   
   -   5        $
��Save��5      $��Verdana)�6    $��
168,0,0,79q�65   ���#A7A88A���#3A6A59$��37��6�   $��Bottom=�6�   $
��Left=�6�   $��86��6�   $��2��6�   5      5       