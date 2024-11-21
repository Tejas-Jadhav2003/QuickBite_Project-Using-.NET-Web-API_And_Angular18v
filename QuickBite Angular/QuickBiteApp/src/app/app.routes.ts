import { Routes } from '@angular/router';
import { Component } from '@angular/core';
import { MenuComponent } from './component/menu/menu.component';
import { HomeComponent } from './component/home/home.component';
import { SignInComponent } from './component/sign-in/sign-in.component';
import { SignUpComponent } from './component/sign-up/sign-up.component';

export const routes: Routes = [
    {
        path: '', component: HomeComponent
    },
    {
        path: 'menu', component: MenuComponent
    },
    {
        path: 'user/sign-in', component: SignInComponent
    },
    {
        path: 'user/sign-up', component: SignUpComponent
    }
];
