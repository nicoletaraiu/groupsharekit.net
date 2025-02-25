﻿using Sdl.Community.GroupShareKit.Exceptions;
using Sdl.Community.GroupShareKit.Models.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sdl.Community.GroupShareKit.Clients
{
    public interface IReportingClient
    {
        /// <summary>
        /// Returns the Predefined Projects report data
        /// </summary>
        /// <param name="options"></param>
        /// <remarks>
        ///  This method requires authentication.
        ///  See the <a href="http://gs2017dev.sdl.com:41234/documentation/api/index#/">API documentation</a> for more information.
        ///  </remarks>
        ///  <exception cref="AuthorizationException">
        ///  Thrown when the current user does not have permission to make the request.
        ///  </exception>
        ///  <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<List<ReportingServicePredefinedProjects>> PredefinedProjects(PredefinedReportsFilters filters);

        /// <summary>
        /// Returns the Predefined Tasks report data
        /// </summary>
        /// <param name="options"></param>
        /// <remarks>
        ///  This method requires authentication.
        ///  See the <a href="http://gs2017dev.sdl.com:41234/documentation/api/index#/">API documentation</a> for more information.
        ///  </remarks>
        ///  <exception cref="AuthorizationException">
        ///  Thrown when the current user does not have permission to make the request.
        ///  </exception>
        ///  <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<List<ReportingServicePredefinedTasks>> PredefinedTasks(PredefinedReportsFilters filters);

        /// <summary>
        /// Returns the Predefined TmLeverage report data
        /// </summary>
        /// <param name="options"></param>
        /// <remarks>
        ///  This method requires authentication.
        ///  See the <a href="http://gs2017dev.sdl.com:41234/documentation/api/index#/">API documentation</a> for more information.
        ///  </remarks>
        ///  <exception cref="AuthorizationException">
        ///  Thrown when the current user does not have permission to make the request.
        ///  </exception>
        ///  <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<List<ReportingServicePredefinedTmLeverage>> PredefinedTmLeverage(PredefinedReportsFilters filters);

        /// <summary>
        /// Returns the Deliveries Due Soon report data
        /// </summary>
        /// <param name="options"></param>
        /// <remarks>
        ///  This method requires authentication.
        ///  See the <a href="http://gs2017dev.sdl.com:41234/documentation/api/index#/">API documentation</a> for more information.
        ///  </remarks>
        ///  <exception cref="AuthorizationException">
        ///  Thrown when the current user does not have permission to make the request.
        ///  </exception>
        ///  <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<ReportingServiceDeliveriesDueSoonProjects> DeliveriesDueSoon(ReportingServiceSortingParameters sortParameters);

        /// <summary>
        /// Returns the Your Tasks report data
        /// </summary>
        /// <param name="options"></param>
        /// <remarks>
        ///  This method requires authentication.
        ///  See the <a href="http://gs2017dev.sdl.com:41234/documentation/api/index#/">API documentation</a> for more information.
        ///  </remarks>
        ///  <exception cref="AuthorizationException">
        ///  Thrown when the current user does not have permission to make the request.
        ///  </exception>
        ///  <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<List<ReportingServiceYourTasks>> YourTasks(ReportingServiceSortingParameters sortParameters);

        /// <summary>
        /// Returns the Projects Per Month report data
        /// </summary>
        /// <param name="options"></param>
        /// <remarks>
        ///  This method requires authentication.
        ///  See the <a href="http://gs2017dev.sdl.com:41234/documentation/api/index#/">API documentation</a> for more information.
        ///  </remarks>
        ///  <exception cref="AuthorizationException">
        ///  Thrown when the current user does not have permission to make the request.
        ///  </exception>
        ///  <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<List<ReportingServiceProjectsPerMonth>> ProjectsPerMonth();

        /// <summary>
        /// Returns the Words Per Month report data
        /// </summary>
        /// <param name="options"></param>
        /// <remarks>
        ///  This method requires authentication.
        ///  See the <a href="http://gs2017dev.sdl.com:41234/documentation/api/index#/">API documentation</a> for more information.
        ///  </remarks>
        ///  <exception cref="AuthorizationException">
        ///  Thrown when the current user does not have permission to make the request.
        ///  </exception>
        ///  <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<List<ReportingServiceWordsPerMonth>> WordsPerMonth();

        /// <summary>
        /// Returns the Words Per Organization report data
        /// </summary>
        /// <param name="options"></param>
        /// <remarks>
        ///  This method requires authentication.
        ///  See the <a href="http://gs2017dev.sdl.com:41234/documentation/api/index#/">API documentation</a> for more information.
        ///  </remarks>
        ///  <exception cref="AuthorizationException">
        ///  Thrown when the current user does not have permission to make the request.
        ///  </exception>
        ///  <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<List<ReportingServiceWordsPerOrganization>> WordsPerOrganization();

        /// <summary>
        /// Returns the Top Language Pairs report data
        /// </summary>
        /// <param name="options"></param>
        /// <remarks>
        ///  This method requires authentication.
        ///  See the <a href="http://gs2017dev.sdl.com:41234/documentation/api/index#/">API documentation</a> for more information.
        ///  </remarks>
        ///  <exception cref="AuthorizationException">
        ///  Thrown when the current user does not have permission to make the request.
        ///  </exception>
        ///  <exception cref="ApiException">Thrown when a general API error occurs.</exception>
        Task<List<ReportingServiceTopLanguagePairs>> TopLanguagePairs();

    }
}
