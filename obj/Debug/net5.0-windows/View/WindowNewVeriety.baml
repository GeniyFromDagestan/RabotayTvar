   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:WpfApp1.ViewWpfApp1.View  5   	   #    WpfApp1.View.WindowNewVeriety   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:WpfApp1.View     5   	     � Title$  WindowNewVeriety��5   	   $	��450��6"   $	��800��6/   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6   �� 5      $	��10* �6    � ColumnDefinitions 5   
   �� 5      $	��15* �6   �� 5      $	��74* �6   .+�5   
   �� $��0��6   $��0��6!   $	��ID:��61   $��Right=�5      $��Center=�6)   $��5q�6D   �� 5   
   $��1��6   $��0��6!   $��Вид Клиента��61   $��Right=�5      $��Center=�6)   $��5q�6D   �� 5   
   -   5         ��Name$ WNPId��5      $��0��6!   $��1��6.   $��20��6>   $��50��6J   $
��Left=�5      $��Center=�6(   $��5q�6C   ${�False��5   !   ��6   �� *Id+6!   �� 5   
   -   5        $ WNPveri��5      $��1��6#   $��1��60   $��20��6@   $	��130��6L   $
��Left=�5       $��Center=�6(   $��5q�6C   ��5!      �� *	Veriety+�� 5$   
   $��0��6   $��2��6%   $��8��69    �� Orientation$ 
Horizontal=�5%      $��Right=�6&   .+�5&      �� -   5         ��Name$ BtSave��5&      $��Сохранить��6%   $��25��69   $��Right=�5'      $	��Top=�6-   $��	5,10,10,5q�5(       �� 	IsDefault$
 True��6$   65   �� 5)      -   5        $ BtCansel��5)      $��Отменить��6'   $��25��6:   $��Right=�5*      $	��Top=�6-   $��	5,10,10,5q�5+       �� IsCancel$
 True��6$   5,      5-      5.      