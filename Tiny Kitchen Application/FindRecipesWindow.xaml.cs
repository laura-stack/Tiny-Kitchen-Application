﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Tiny_Kitchen_Application
{
    /* 
    private string appID= "faef1f70";
        private string apiKey="382682029b8bfe878596ffd8332acfd6"; 
        async function sendApiRequest(){
            response = await fetch("https://api.edamam.com/api/recipes/v2?app_id="+appID+"app_key="+apiKey);
            console.log(response); 
         }

    */
    public partial class FindRecipesWindow : Window
    {
        public FindRecipesWindow()
        {
            InitializeComponent();
        }
    }

    /*
     <Label Content="Collections" FontFamily="Verdana" FontSize="18" FontWeight="Medium" HorizontalAlignment="Left" Margin="166,14,0,0" VerticalAlignment="Top" Height="44" Width="134" Foreground="#D6C18A"/>
        <ToggleButton FontFamily="Verdana" Margin="364,24,0,0" Background="#A7A88A" Foreground="#3A6A59" Click="CreateCollectionButton_Click" Height="71" VerticalAlignment="Top" HorizontalAlignment="Left" Width="70">
            <Image Height="100" Width="100"/>
        </ToggleButton>
        <Popup Margin="10,10,0,13" Name="Popup_Window" HorizontalAlignment="Center" VerticalAlignment="Center" Placement="Center" Width="250" Height="200" AllowsTransparency="True" IsOpen="False">
            <Grid Background="#A7A88A">
                <Label Content="Enter Collection Name:" Margin="0, 0, 0, 0" HorizontalAlignment="Center" Width="150" Height="50"  VerticalAlignment="Top"/>
                <TextBox Name= "collectionName" Margin="0,50,10,0" TextWrapping="Wrap" HorizontalAlignment="Center" Width="150" Height="23" VerticalAlignment="Top"/>
                <Button 
                    FontFamily="Verdana" Margin = "5, 5, 5, 38" Background="#3A6A59" Click="SaveCollectionName_Click" Height ="35" Width ="70" HorizontalAlignment ="Center" VerticalAlignment ="Bottom"/>

                <Label Content="Save" FontFamily="Verdana" FontSize="16" FontWeight="Medium" HorizontalAlignment="Center" VerticalAlignment ="Bottom" Margin="5, 5, 5, 38"/>
                <Button
                    FontFamily="Verdana" Margin="0, 0, 0, 0" Background="#3A6A59" Click="ExitCollectionCreator_Click" Height="35" Width="70" HorizontalAlignment="Center" VerticalAlignment="Bottom"/>
                <Label Content="Quit" FontFamily="Verdana" FontSize="16" FontWeight="Medium" HorizontalAlignment="Center" VerticalAlignment="Bottom" Margin="0, 0, 0, 0"/>
            </Grid>
        </Popup>
        <Image HorizontalAlignment="Left" Height="49" Margin="384,33,0,0" VerticalAlignment="Top" Width="32" Source="/Add-icon.png"/>
        <Label Content="Create" FontFamily ="Verdana" HorizontalAlignment="Left" Margin="374,68,0,0" VerticalAlignment="Top"/>
        <Button Content="View My Collections" Click="ViewCollection_Click" FontFamily="Verdana"  Background="#A7A88A" FontSize="13" HorizontalAlignment="Center" VerticalAlignment="Top" Height="52" Width="194" Margin="0,181,0,0"/>
     */
}
