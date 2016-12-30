﻿using AutoMapper;
using ObajuStore.Model.Models;
using ObajuStore.Web.Models;
using System.Collections.Generic;

namespace ObajuStore.Web.Mappings
{
    public class AutoMapperConfiguration
    {
        public static void Configure()
        {
            Mapper.Initialize(x =>
            {
                x.CreateMap<Post, PostViewModel>();
                x.CreateMap<ProductCategory, ProductCategoryViewModel>();
                x.CreateMap<PostCategory, PostCategoryViewModel>();
                x.CreateMap<PostTag, PostTagViewModel>();
                x.CreateMap<Tag, TagViewModel>();
                x.CreateMap<Product, ProductViewModel>();
                x.CreateMap<ProductTag, ProductTagViewModel>();
                x.CreateMap<Brand, BrandViewModel>();
                x.CreateMap<ContactDetail, ContactDetailViewModel>();
                x.CreateMap<Slide, SlideViewModel>();
                x.CreateMap<Order, OrderViewModel>();
                x.CreateMap<OrderDetail, OrderDetailViewModel>();
                x.CreateMap<Feedback, FeedbackViewModel>();
                x.CreateMap<Footer, FooterViewModel>();
                x.CreateMap<Page, PageViewModel>();
                x.CreateMap<Wishlist, WishlistViewModel>();
                x.CreateMap<Vehicle, VehicleViewModel>();
                x.CreateMap<TrackOrder, TrackOrderViewModel>();
                x.CreateMap<ApplicationRole, ApplicationRoleViewModel>();
                x.CreateMap<ApplicationUser, ApplicationUserViewModel>();
            });
        }

    }
}