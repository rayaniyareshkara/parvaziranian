using System;
using Microsoft.Practices.Unity;
using CMS.Infrastructure.Portal.Classes;
using CMS.Infrastructure.Portal.Interfaces;
using System.Web.Mvc;
using CMS.Infrastructure.Homa.Classes;
using CMS.Infrastructure.Homa.Interfaces;
using CMS.Infrastructure.Notification;
using CMS.Infrastructure.PortalCustomize.Classes;
using CMS.Infrastructure.PortalCustomize.Interfaces;
using Microsoft.Practices.Unity.Mvc;
using CMS.Web.Models;
using CMS.Infrastructure.Support.Interfaces;
using CMS.Infrastructure.Support.Classes;
using CMS.Infrastructure.Education.Interfaces;
using CMS.Infrastructure.Education.Classes;
using CMS.Infrastructure.Exam.Interfacess;
using CMS.Infrastructure.Exam.Classes;
using CMS.Infrastructure.Aseman.Interfaces;
using CMS.Infrastructure.Aseman.Classes;
using CMS.Infrastructure.Admin.Interfaces;
using CMS.Infrastructure.Admin.Classes;

namespace CMS.Web
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container

        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });
        public static IUnityContainer _container;
        public static void RegisterComponents()
        {
            _container = new UnityContainer();
            _container.RegisterType<IMenu, MenuDataServices>()
                .RegisterType<INews, NewsDataServices>()
                .RegisterType<IFooter, FooterDataServices>()
                .RegisterType<IGalleries, GalleriesDataServices>()
                .RegisterType<IImageGallery, ImageGalleryDataServices>()
                .RegisterType<IPages, PagesDataServices>()

                .RegisterType<ISmsSendingService, SmsSendingService>()

                .RegisterType<ITags, TagsDataServices>()
                .RegisterType<ILanguages, LanguagesDataServices>()
                .RegisterType<IUsersSite, UsersSiteDataServices>()

                .RegisterType<IAccessibility, AccessibilityDataServices>()
                .RegisterType<IPageMaker, PageMakerDataServices>()

                .RegisterType<IBankTransaction, BankTransactionDataServices>()
                .RegisterType<IPageMakerName, PageMakerNameDataServices>()

                .RegisterType<IGalleries, GalleriesDataServices>()
                .RegisterType<Infrastructure.Admin.Interfaces.IAlbum, Infrastructure.Admin.Classes.AlbumDataServices>()
                .RegisterType<IImageGallery, ImageGalleryDataServices>()
                .RegisterType<Infrastructure.Admin.Interfaces.ICart, Infrastructure.Admin.Classes.CartDataSerives>()
                .RegisterType<Infrastructure.Admin.Interfaces.ICartItems, Infrastructure.Admin.Classes.CartItemsDataServices>()

                .RegisterType<IUsersActiveCookie, UsersActiveCookieDataServices>()
                .RegisterType<IUsersSiteActiveCookie, UsersSiteActiveCookieDataServices>()
                .RegisterType<IEmailGroups, EmailGroupsDataServices>()
                .RegisterType<IGroupMember_Emails, GroupMember_EmailsDataServices>()
                .RegisterType<IGroupMembers, GroupMembersDataServices>()
                .RegisterType<IRole_UsersSite, Role_UsersSiteDataServices>()
                .RegisterType<ISendingStatus, SendingStatusDataServices>()
                .RegisterType<ISendType, SendTypeDataServices>()
                .RegisterType<ISmsGroups, SmsGroupsDataServices>()

                .RegisterType<IUsersActiveType, UsersActiveTypeDataServices>()
                .RegisterType<IPageName, PageNameDataServices>()
                .RegisterType<IAccessPage_Users, AccessPage_UsersDataServices>()
                .RegisterType<IFooterType, FooterTypeDataServices>()
                .RegisterType<IPages, PagesDataServices>()
                .RegisterType<ISessionLogin, SessionLoginDataServices>()
                .RegisterType<IFiles, FilesDataServices>()

                .RegisterType<ICriticismAnswer, CriticismAnswerDataServices>()
                .RegisterType<ICriticismIntroduction, CriticismIntroductionDataServices>()
                .RegisterType<ICriticismQuestion, CriticismQuestionDataServices>()
                .RegisterType<ICriticismResult, CriticismResultDataServices>()
                .RegisterType<IUsers, UsersDataServices>()
                .RegisterType<IAdminPages, AdminPagesDataServices>()
                .RegisterType<CMS.Infrastructure.Portal.Interfaces.IGroup, CMS.Infrastructure.Portal.Classes.GroupDataServices>()
                .RegisterType<IUsersGroup, UsersGroupDataServices>()
                .RegisterType<IAccessGroup, AccessGroupDataServices>()
                .RegisterType<IUserSiteRole, UserSiteRoleDataServices>()
                .RegisterType<IAccessUsers, AccessUsersDataServices>()

                .RegisterType<IComment, CommentDataServices>()
                .RegisterType<ITypeNews, TypeNewsDataServices>()
                .RegisterType<ICustomePage, CustomePageDataServices>()
                .RegisterType<ISessionPermission, SessionPermissions>()

                .RegisterType<IDisposableCode, DisposableCodeDataServices>()


                   .RegisterType<ISelectedNews, SelectedNewsDataServices>()

  .RegisterType<IExamType, ExamTypeDataServices>()
   .RegisterType<IExamCenter, ExamCenterDataServices>()
 .RegisterType<IExamCenterPhone, ExamCenterPhoneDataServices>()
 .RegisterType<IExam, ExamDataServices>()
 .RegisterType<IExamHardship, ExamHardshipDataServices>()
 .RegisterType<IExamFrame, ExamFrameDataServices>()

 .RegisterType<Infrastructure.Portal.Interfaces.IGroup, GroupDataServices>()
 .RegisterType<IGroup1, Group1DataServices>()
 .RegisterType<IAsemanRole, AsemanRoleDataServices>()
  .RegisterType<IContactUs, ContactUsDataServices>()
   .RegisterType<IFacilities, FacilitiesDataServices>()
    .RegisterType<IJobOffer, JobOfferDataServices>()
     .RegisterType<IInvestment, InvestmentDataServices>()

                      .RegisterType<IInfoGraphic, InfoGraphicDataServices>()
                      .RegisterType<ITypeOfInfoGraphic, TypeOfInfoGraphicDataServices>()
                      .RegisterType<IInterView, InterViewDataServices>()
                      .RegisterType<ITypeOfInterView, TypeOfInterViewDataServices>()
                      .RegisterType<IInterViewQuestion, InterViewQuestionDataServices>()
                      .RegisterType<IPodCast, PodCastDataServices>()
                      .RegisterType<ITypeOfPodCast, TypeOfPodCastDataServices>()
                      .RegisterType<ITypeOfNews, TypeOfNewsDataServices>()
                      .RegisterType<INewsComment, NewsCommentDataServices>()

                      .RegisterType<IDegreeTime, DegreeTimeDataServices>()
                      .RegisterType<IRequestUser, RequestUserDataServices>()
                      .RegisterType<IBranchDegree, BranchDegreeDataServices>()
                        .RegisterType<IDegreeTerm, DegreeTermDataServices>()
                          .RegisterType<IDegreeTermStudent, DegreeTermStudentDataServices>()
                            .RegisterType<ICourseTerm, CourseTermDataServices>()
                              .RegisterType<ICourseTermStudent, CourseTermStudentDataServices>()
                                .RegisterType<ICourseTermTime, CourseTermTimeDataServices>()
                                  .RegisterType<ICourseTermStudentCheck, CourseTermStudentCheckDataServices>()
                                    .RegisterType<IStudentComment, StudentCommentDataServices>()
                                    .RegisterType<IExamQuestion, ExamQuestionDataServices>()


                .RegisterType<ITicket, TicketDataServices>()
                .RegisterType<ITicketAudit, TicketAuditDataServices>()
                .RegisterType<ITicketCategory, TicketCategoryDataServices>()
                .RegisterType<ITicketCategory_User, TicketCategory_UserDataServices>()
                .RegisterType<ITicketComment, TicketCommentDataServices>()
                .RegisterType<ITicketFile, TicketFileDataServices>()
                .RegisterType<ITicketPriority, TicketPriorityDataServices>()
                .RegisterType<ITicketStatus, TicketStatusDataServices>()
                .RegisterType<ITicketSetting, TicketSettingDataServices>()
                .RegisterType<IUsersSiteActiveCookie, UsersSiteActiveCookieDataServices>()
                .RegisterType<IWishList, WishListDataServices>()

                .RegisterType<ICountry, CountryDataServices>()
                .RegisterType<IProvince, ProvinceDataServices>()
                .RegisterType<ICity, CityDataService>()


                .RegisterType<IReport, ReportDataServices>()

                .RegisterType<INotification, NotificationDataServices>()
                .RegisterType<CMS.Infrastructure.Notification.IGroup,
                    CMS.Infrastructure.Notification.Classes.GroupDataServices>()
                .RegisterType<CMS.Infrastructure.Notification.IUserGroup,
                    CMS.Infrastructure.Notification.Classes.UserGroupDataServices>()

             .RegisterType<ICourse, CourseDataServices>()
             .RegisterType<IDegree, DegreeDataServices>()
             .RegisterType<IHeadLine, HeadLineDataServices>()
             .RegisterType<IQuestion, QuestionDataServices>()
             .RegisterType<IQuestionOption, QuestionOptionDataServices>()
             .RegisterType<IQuestionType, QuestionTypeDataServices>()
             .RegisterType<IQuestionHardship, QuestionHardshipDataServices>()
             .RegisterType<ICourseImplement, CourseImplementDataServices>()
             .RegisterType<ICourseSource, CourseSourceDataServices>()
             .RegisterType<IDegreePreRequisite, DegreePreRequisiteDataServices>()
             .RegisterType<IHeadLineSource, HeadLineSourceDataServices>()
             .RegisterType<IBranch, BranchDataServices>()
             .RegisterType<IBranchPhone, BranchPhoneDataServices>()
             .RegisterType<IMaster, MasterDataServices>()
             .RegisterType<IMasterShow, MasterShowDataServices>()
             .RegisterType<IMasterDegree, MasterDegreeDataServices>()
             .RegisterType<IMasterResume, MasterResumeDataServices>()
             .RegisterType<IStudent, StudentDataServices>()
             .RegisterType<IExaminer, ExaminerDataServices>()
             .RegisterType<ILibrary, LibraryDataServices>()
             .RegisterType<IMasterCourse, MasterCourseDataServices>()
             .RegisterType<IMainCourse, MainCourseDataServices>()
              .RegisterType<IMainCourse, MainCourseDataServices>()
               .RegisterType<IMasterSocialNetWork, MasterSocialNetWorkDataServices>()
                .RegisterType<IMasterBranch, MasterBranchDataServices>()
                .RegisterType<IFacilityRequest, FacilityRequestDataServices>()
                .RegisterType<INewsCategories, NewsCategoryDataServices>()
                  .RegisterType<ITags, TagsDataServices>()
                  .RegisterType<IMetaTag, MetaTagDataServices>()
                  .RegisterType<IAsemanRoleUser, AsemanRoleUserDataServices>()
                  .RegisterType<IInvestmentRequest, InvestmentRequestDataServices>()
                     .RegisterType<IUserCertificate, UserCertificateDataServices>()
                     .RegisterType<IMobileCheck, MobileCheckDataServices>()
                     .RegisterType<IStudentRequest, StudentRequestDataServices>()
    .RegisterType<IExamRequest, ExamRequestDataServices>()
    .RegisterType<ICourseSession, CourseSessionDataServices>()
    .RegisterType<IMainCourseTerm, MainCourseTermDataServices>()
    .RegisterType<IMainCourseTermStudent, MainCourseTermStudentDataServices>()
    .RegisterType<IResumeType, ResumeTypeDataServices>()

      .RegisterType<IFinanceDocType, FinanceDocTypeDataServices>()
        .RegisterType<IFinanceDoc, FinanceDocDataServices>()
        .RegisterType<ICourseTermHeadLineCheck, CourseTermHeadLineCheckDataServices>()

                    .RegisterType<ICourseTermTimeHomeWork, CourseTermTimeHomeWorkDataServices>()
            .RegisterType<ICourseTermTimeHomeWorkStudent, CourseTermTimeHomeWorkStudentDataServices>()
                        .RegisterType<IAnnouncement, AnnouncementDataServices>()
                        .RegisterType<IHeadLineFile, HeadLineFileDataServices>()

                         .RegisterType<ICourseTermQuiz, CourseTermQuizDataServices>()
                          .RegisterType<ICourseTermQuizQuestion, CourseTermQuizQuestionDataServices>()
                         .RegisterType<ICourseTermQuizAnswer, CourseTermQuizAnswerDataServices>()

                         .RegisterType<ICourseTermSurvey, CourseTermSurveyDataServices>()

                .RegisterType<IArticle, ArticleDataServices>()
                .RegisterType<IArticleCategory, ArticleCategoryDataServices>()
                .RegisterType<IArticleComment, ArticleCommentDataServices>()
                .RegisterType<IArticleSelected, ArticleSelectedDataServices>()
                        .RegisterType<ICourseTermQuizUser, CourseTermQuizUserDataServices>()
                        .RegisterType<IBranchClass, BranchClassDataServices>()
                                  .RegisterType<ILocalIP, LocalIPDataServices>()
                                  .RegisterType<ISlider, SliderDataServices>()
                                  .RegisterType<ISliderPage, SliderPageDataServices>()
             .RegisterType<IMasterLibrary, MasterLibraryDataServices>();







            DependencyResolver.SetResolver(new UnityDependencyResolver(_container));
        }

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below. Make sure to add a Microsoft.Practices.Unity.Configuration to the using statements.
            //container.LoadConfiguration();
            //container.RegisterType<ISessionPermission , SessionPermissions>();
            // TODO: Register your types here
            // container.RegisterType<IProductRepository, ProductRepository>();

            container.RegisterType<IMenu, MenuDataServices>()
                .RegisterType<INews, NewsDataServices>()
                .RegisterType<IPodCast, PodCastDataServices>()
                  .RegisterType<IInterView, InterViewDataServices>()
                  .RegisterType<IInfoGraphic, InfoGraphicDataServices>()
                  .RegisterType<ITypeOfInfoGraphic, TypeOfInfoGraphicDataServices>()
                  .RegisterType<ITypeOfInterView, TypeOfInterViewDataServices>()
                  .RegisterType<ITypeOfPodCast, TypeOfPodCastDataServices>()
                  .RegisterType<ITypeOfNews, TypeOfNewsDataServices>()

                .RegisterType<IFooter, FooterDataServices>()
                .RegisterType<IGalleries, GalleriesDataServices>()
                .RegisterType<IImageGallery, ImageGalleryDataServices>()
                .RegisterType<IPages, PagesDataServices>()
                .RegisterType<ISmsSendingService, SmsSendingService>()

                .RegisterType<ITags, TagsDataServices>()
                .RegisterType<ILanguages, LanguagesDataServices>()
                .RegisterType<IUsersSite, UsersSiteDataServices>()

                .RegisterType<IAccessibility, AccessibilityDataServices>()
                .RegisterType<IPageMaker, PageMakerDataServices>()

                .RegisterType<IBankTransaction, BankTransactionDataServices>()

                .RegisterType<IPageMakerName, PageMakerNameDataServices>()
                .RegisterType<IGalleries, GalleriesDataServices>()
                .RegisterType<Infrastructure.Admin.Interfaces.IAlbum, Infrastructure.Admin.Classes.AlbumDataServices>()
                .RegisterType<IImageGallery, ImageGalleryDataServices>()

                .RegisterType<Infrastructure.Admin.Interfaces.ICart, Infrastructure.Admin.Classes.CartDataSerives>()
                .RegisterType<Infrastructure.Admin.Interfaces.ICartItems,
                    Infrastructure.Admin.Classes.CartItemsDataServices>()
                .RegisterType<IUsersActiveCookie, UsersActiveCookieDataServices>()
                .RegisterType<IUsersActiveCookie, UsersActiveCookieDataServices>()
                .RegisterType<IEmailGroups, EmailGroupsDataServices>()
                .RegisterType<IGroupMember_Emails, GroupMember_EmailsDataServices>()
                .RegisterType<IGroupMembers, GroupMembersDataServices>()
                .RegisterType<IRole_UsersSite, Role_UsersSiteDataServices>()
                .RegisterType<ISendingStatus, SendingStatusDataServices>()
                .RegisterType<ISendType, SendTypeDataServices>()
                .RegisterType<ISmsGroups, SmsGroupsDataServices>()
                .RegisterType<IUsersActiveType, UsersActiveTypeDataServices>()
                .RegisterType<IPageName, PageNameDataServices>()
                .RegisterType<IAccessPage_Users, AccessPage_UsersDataServices>()
                .RegisterType<IFooterType, FooterTypeDataServices>()
                .RegisterType<IPages, PagesDataServices>()
                .RegisterType<ISessionLogin, SessionLoginDataServices>()
                .RegisterType<IFiles, FilesDataServices>()
                .RegisterType<ICriticismAnswer, CriticismAnswerDataServices>()
                .RegisterType<ICriticismIntroduction, CriticismIntroductionDataServices>()
                .RegisterType<ICriticismQuestion, CriticismQuestionDataServices>()
                .RegisterType<ICriticismResult, CriticismResultDataServices>()
                .RegisterType<IUsers, UsersDataServices>()
                .RegisterType<IAdminPages, AdminPagesDataServices>()
                .RegisterType<CMS.Infrastructure.Portal.Interfaces.IGroup,
                    CMS.Infrastructure.Portal.Classes.GroupDataServices>()
                .RegisterType<IUsersGroup, UsersGroupDataServices>()
                .RegisterType<IAccessGroup, AccessGroupDataServices>()
                .RegisterType<IUserSiteRole, UserSiteRoleDataServices>()
                .RegisterType<IAccessUsers, AccessUsersDataServices>()
                .RegisterType<IMetaTag, MetaTagDataServices>()
                .RegisterType<IComment, CommentDataServices>()

                .RegisterType<ITypeNews, TypeNewsDataServices>()
                .RegisterType<ICustomePage, CustomePageDataServices>()
                .RegisterType<IUsersSiteActiveCookie, UsersSiteActiveCookieDataServices>()

                .RegisterType<IReport, ReportDataServices>()

                       .RegisterType<ICourse, CourseDataServices>()
                       .RegisterType<IDegree, DegreeDataServices>()
                       .RegisterType<IHeadLine, HeadLineDataServices>()
                       .RegisterType<IQuestion, QuestionDataServices>()
                       .RegisterType<IQuestionOption, QuestionOptionDataServices>()
                       .RegisterType<IQuestionType, QuestionTypeDataServices>()
                       .RegisterType<IQuestionHardship, QuestionHardshipDataServices>()
                       .RegisterType<ICourseImplement, CourseImplementDataServices>()
                       .RegisterType<ICourseSource, CourseSourceDataServices>()
                       .RegisterType<IDegreePreRequisite, DegreePreRequisiteDataServices>()
                       .RegisterType<IHeadLineSource, HeadLineSourceDataServices>()
                      .RegisterType<IBranch, BranchDataServices>()
                      .RegisterType<IBranchPhone, BranchPhoneDataServices>()
                      .RegisterType<IMaster, MasterDataServices>()
                      .RegisterType<IMasterDegree, MasterDegreeDataServices>()
                      .RegisterType<IMasterResume, MasterResumeDataServices>()
                      .RegisterType<IStudent, StudentDataServices>()
                      .RegisterType<IStudentDegree, StudentDegreeDataServices>()
                      .RegisterType<IWishList, WishListDataServices>()
                      .RegisterType<IDegreeTime, DegreeTimeDataServices>()
                      .RegisterType<IRequestUser, RequestUserDataServices>()
                      .RegisterType<IMasterCourse, MasterCourseDataServices>()
                      .RegisterType<IMainCourse, MainCourseDataServices>()
                      .RegisterType<IFacilityRequest, FacilityRequestDataServices>()
                      .RegisterType<INewsCategories, NewsCategoryDataServices>()
                        .RegisterType<IMetaTag, MetaTagDataServices>()
                          .RegisterType<IAsemanRoleUser, AsemanRoleUserDataServices>()
                           .RegisterType<IInvestmentRequest, InvestmentRequestDataServices>()
                              .RegisterType<IUserCertificate, UserCertificateDataServices>()
                                 .RegisterType<IMobileCheck, MobileCheckDataServices>()
                                     .RegisterType<IStudentRequest, StudentRequestDataServices>()
                                     .RegisterType<IExamRequest, ExamRequestDataServices>()
                                      .RegisterType<ICourseSession, CourseSessionDataServices>()
                                       .RegisterType<IMainCourseTerm, MainCourseTermDataServices>()
                                        .RegisterType<IMainCourseTermStudent, MainCourseTermStudentDataServices>()
                .RegisterType<IResumeType, ResumeTypeDataServices>()
                .RegisterType<IFinanceDocType, FinanceDocTypeDataServices>()
                .RegisterType<IFinanceDoc, FinanceDocDataServices>()
                .RegisterType<ICourseTermStudentCheck, CourseTermStudentCheckDataServices>()
                .RegisterType<ICourseTermHeadLineCheck, CourseTermHeadLineCheckDataServices>()
                .RegisterType<ICourseTermTimeHomeWork, CourseTermTimeHomeWorkDataServices>()
                .RegisterType<ICourseTermTimeHomeWorkStudent, CourseTermTimeHomeWorkStudentDataServices>()
                .RegisterType<IAnnouncement, AnnouncementDataServices>()
                .RegisterType<IHeadLineFile, HeadLineFileDataServices>()
                .RegisterType<ICourseTermQuiz, CourseTermQuizDataServices>()
                .RegisterType<ICourseTermQuizQuestion, CourseTermQuizQuestionDataServices>()
                .RegisterType<ICourseTermQuizAnswer, CourseTermQuizAnswerDataServices>()
                .RegisterType<ICourseTermSurvey, CourseTermSurveyDataServices>()
                .RegisterType<IArticle, ArticleDataServices>()
                .RegisterType<IArticleCategory, ArticleCategoryDataServices>()
                .RegisterType<IArticleComment, ArticleCommentDataServices>()
                .RegisterType<IArticleSelected, ArticleSelectedDataServices>()
                .RegisterType<ICourseTermQuizUser, CourseTermQuizUserDataServices>()
                .RegisterType<ILocalIP, LocalIPDataServices>()
                .RegisterType<ISlider, SliderDataServices>()
                .RegisterType<ISliderPage, SliderPageDataServices>()

                .RegisterType<ISessionPermission, SessionPermissions>();
        }
    }
}
