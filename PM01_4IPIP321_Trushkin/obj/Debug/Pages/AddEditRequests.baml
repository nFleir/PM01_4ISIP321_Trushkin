   M S B A M L   `   `   `  ����Q  MPM01_4IPIP321_Trushkin, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:PM01_4IPIP321_Trushkin.PagesPM01_4IPIP321_Trushkin.Pages  5      2    ,PM01_4IPIP321_Trushkin.Pages.AddEditRequests   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:PM01_4IPIP321_Trushkin.Pages     5        N� Title$  AddEditRequests��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5        $��LabelAddEdit��5   G   $#��Добавить запрос��6   $��0��6*   $��0��67   6G   �� 5   
   $#��Выберите жителя��6   $��1��6*   $��0��67   �� 5   
   -   5        $��
CitizenBox��5      $��1��6%   $��1��62   �� 5   
   $-��'Выберите исполнителя��6   $��2��6/   $��0��6<   �� 5    
   -   5        $��EmployerBox��5       $��2��6&   $��1��63   �� 5"   
   $��Статус заявки��6   $��3��6(   $��0��65   �� 5#   
   -   5        $��	StatusBox��5#      $��3��6$   $��1��61   �� 5%   
   $%��Введите описание��6   $��4��6+   $��0��68   �� 5&   
   -   5        $��DesctiptBox��5&      $��4��6%   $��1��62   ��6B   �� *Description+�� 5)   
   -   5         ��Name$ CancelButton��5)      $��0��6'   $��5��67   $��Отмена��6D   6U   �� 5*   
   -   5        $ AddEditButton��5*      $��1��6(   $��5��68   $��Добавить��6E   6X   5,      5-      