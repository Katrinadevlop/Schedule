   M S B A M L   `   `   `  ����C  ?Schedule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ScheduleSchedule  5   	       Schedule.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Schedule     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��400��6)   .��5
      � -   5         �Name$ AuthorizationGrid��5
      $y�Visible=�6&   $	��450��6;   $	��400��6H    � RowDefinitions 5   
   �� 5      $	��61* �6   �� 5      $
��373* �6   .+�5   
   �� -   5         ��Name$ authorizationText��5      $��Авторизация��5      $��18(�5      $��Center=�5      $	��Top=�5      $��0,30,0,0q�5      �� 5   
   $��Ник��5      
�������$	��Top=�5      $
��Left=�5      $��
125,39,0,0q�5      $��1��6!   �� 5   
   -   5         ��Name$ nicknameTextBox��5      $	��150��5       $��30��5!      $��125,64,125,0q�5"      $	��Top=�5#      $��1��6%   �� 5%   
   $��Пароль��5&      
�������$	��Top=�5(      $
��Left=�5)      $��125,116,0,0q�5*      $��1��6"   �� 5,   
   -   5        $ passwordTextBox��5-      $	��150��5.      $��30��5/      $��125,141,125,0q�50      $	��Top=�51      $��1��6%   �� 53   
   -   5         ��Name$ pictureBoxCaptcha��53      $	��200��6+   $��50��67   $��101,176,99,0q�6C   $	��Top=�6Y   $��1��6q   �� 55   
   -   5        $ chaptaTextBox��56      $	��150��57      $��30��58      $��125,247,125,0q�59      $	��Top=�5:      $��1��6%   �� 5<   
   -   5         ��Name$ authorizationButton��5=      $��80��5>      $��30��5?      
�������$��160,279,160,0q�5A      $	��Top=�5B      $��
Войти��5C      $��1��5D   /   �� 5F   
   -   5        $ goToRegistrationButton��5G      $��80��5H      $��20��5I      $��160,329,160,0q�5J      $	��Top=�5K      $��Регистрация��5L      $��1��6    5M      5N      5O      