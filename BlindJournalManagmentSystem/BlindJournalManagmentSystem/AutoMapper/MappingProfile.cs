using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using BlindJournalManagmentSystem.ViewModels;
using BlindJournalManagmentSystem.DTOs;
using BlindJournalManagmentSystem.Models;
using BlindJournalManagmentSystem.ViewModels;

namespace BlindJournalManagmentSystem.AutoMapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<FieldDTO, Field>();
            CreateMap<Field, FieldDTO > ();

            CreateMap<TempArticle, StepOneViewModel>();
            CreateMap<StepOneViewModel, TempArticle > ();

            CreateMap<TempArticle, StepTwoViewModel>();
            CreateMap<StepTwoViewModel, TempArticle>();

            CreateMap<TempArticle, StepThreeViewModel>();
            CreateMap<StepThreeViewModel, TempArticle>();

            CreateMap<TempArticle, StepFourViewModel>();
            CreateMap<StepFourViewModel, TempArticle>();

            CreateMap<TempArticle, StepFiveViewModel>();
            CreateMap<StepFiveViewModel, TempArticle>();

            CreateMap<TempArticle, StepSixViewModel>();
            CreateMap<StepSixViewModel, TempArticle>();

            CreateMap<TempArticle, TempArticleViewModel>();
            CreateMap<TempArticleViewModel, TempArticle>();
        }
    }
}