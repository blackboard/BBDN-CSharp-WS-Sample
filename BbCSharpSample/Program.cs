/* # Copyright (C) 2015, Blackboard Inc.
 * All rights reserved.
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 * 
 *  -- Redistributions of source code must retain the above copyright
 *     notice, this list of conditions and the following disclaimer.
 * 
 *  -- Redistributions in binary form must reproduce the above copyright
 *     notice, this list of conditions and the following disclaimer in the
 *     documentation and/or other materials provided with the distribution.
 * 
 *  -- Neither the name of Blackboard Inc. nor the names of its contributors 
 *     may be used to endorse or promote products derived from this 
 *     software without specific prior written permission.
 *  
 * THIS SOFTWARE IS PROVIDED BY BLACKBOARD INC ``AS IS'' AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL BLACKBOARD INC. BE LIABLE FOR ANY
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BbWsClient;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        /// Declare all WebService wrappers with suffiecient scope to use throughout the application.
        static WebserviceWrapper ws;
        static AnnouncementWrapper ann;
        static CalendarWrapper cal;
        static ContentWrapper cnt;
        static ContextWrapper ctx;
        static CourseWrapper crs;
        static CourseMembershipWrapper crm;
        static GradebookWrapper grd;
        static UserWrapper usr;
        static UtilWrapper utl;

        //  Auth State variable
        static Boolean loggedIn = false;

        // DEBUG constant. Setting to true will display additional information in the console.
        const Boolean DEBUG = true;
        // Constant for expected life of Web Service session. 
        const long EXPECTED_LIFE = 10000000;
        // Constant to determine if certificate errors should be ignored. This should only be true if
        // testing against a Learn instance with self-signed certificates, like the Developer VM
        const Boolean IGNORE_CERT_ERRORS = true;
        
        static void Main()
        {
            // If running against a Development system with a self-signed SSL Certificate...
            if (IGNORE_CERT_ERRORS)
            {
                // Ignore the certificate failure
                // DO NOT DO THIS IN A PRODUCTION APPLICATION OR ENVIRONMENT!!
                System.Net.ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmGetData());
        }

        static public Boolean registerTool(String host, String vendor, String program, String secret, String regpass)
        {
            // Configure and initialize Web Service Wrapper
            ws = new WebserviceWrapper(host, vendor, program, EXPECTED_LIFE);
            // Initialize the web service session. Under the covers, this takes care of Context.initialize()
            ws.initialize_v1();
            
            // Create a string array of requested entitlements. This is overkill for this sample.
            string [] tools = new string [] {   "Announcement.WS:createCourseAnnouncements",
						"Announcement.WS:createOrgAnnouncements",
						"Announcement.WS:createSystemAnnouncements",
						"Announcement.WS:deleteCourseAnnouncements",
						"Announcement.WS:deleteOrgAnnouncements",
						"Announcement.WS:deleteSystemAnnouncements",
						"Announcement.WS:getCourseAnnouncements",
						"Announcement.WS:getOrgAnnouncements",
						"Announcement.WS:getSystemAnnouncements",
						"Announcement.WS:updateCourseAnnouncements",
						"Announcement.WS:updateOrgAnnouncements",
						"Announcement.WS:updateSystemAnnouncements",
						"Calendar.WS:canUpdateCourseCalendarItem",
						"Calendar.WS:canUpdateInstitutionCalendarItem",
						"Calendar.WS:canUpdatePersonalCalendarItem",
						"Calendar.WS:createCourseCalendarItem",
						"Calendar.WS:createInstitutionCalendarItem",
						"Calendar.WS:createPersonalCalendarItem",
						"Calendar.WS:deleteCourseCalendarItem",
						"Calendar.WS:deleteInstitutionCalendarItem",
						"Calendar.WS:deletePersonalCalendarItem",
						"Calendar.WS:getCalendarItem",
						"Calendar.WS:saveCourseCalendarItem",
						"Calendar.WS:saveInstitutionCalendarItem",
						"Calendar.WS:savePersonalCalendarItem",
						"Calendar.WS:updateCourseCalendarItem",
						"Calendar.WS:updateInstitutionCalendarItem",
						"Calendar.WS:updatePersonalCalendarItem",
						"Content.WS:addContentFile",
						"Content.WS:deleteContentFiles",
						"Content.WS:deleteContents",
						"Content.WS:deleteCourseTOCs",
						"Content.WS:deleteLinks",
						"Content.WS:getContentFiles",
						"Content.WS:getFilteredContent",
						"Content.WS:getFilteredCourseStatus",
						"Content.WS:getLinksByReferredToType",
						"Content.WS:getLinksByReferrerType",
						"Content.WS:getReviewStatusByCourseId",
						"Content.WS:getTOCsByCourseId",
						"Content.WS:loadContent",
						"Content.WS:removeContent",
						"Content.WS:saveContent",
						"Content.WS:saveContentsReviewed",
						"Content.WS:saveCourseTOC",
						"Content.WS:saveLink",
						"Context.WS:emulateUser", 
						"Context.WS:getMemberships", 
						"Context.WS:getMyMemberships",
						"Course.WS:changeCourseBatchUid",
						"Course.WS:changeCourseCategoryBatchUid",
						"Course.WS:changeCourseDataSourceId",
						"Course.WS:changeOrgBatchUid",
						"Course.WS:changeOrgCategoryBatchUid",
						"Course.WS:changeOrgDataSourceId",
						"Course.WS:createCourse",
						"Course.WS:createOrg",
						"Course.WS:deleteCartridge",
						"Course.WS:deleteCourse",
						"Course.WS:deleteCourseCategory",
						"Course.WS:deleteCourseCategoryMembership",
						"Course.WS:deleteGroup",
						"Course.WS:deleteOrg",
						"Course.WS:deleteOrgCategory",
						"Course.WS:deleteOrgCategoryMembership",
						"Course.WS:deleteStaffInfo",
						"Course.WS:getAvailableGroupTools",
						"Course.WS:getCartridge",
						"Course.WS:getCategories",
						"Course.WS:getCategoryMembership",
						"Course.WS:getClassifications",
						"Course.WS:getCourse",
						"Course.WS:getGroup",
						"Course.WS:getOrg",
						"Course.WS:getStaffInfo",
						"Course.WS:saveCartridge",
						"Course.WS:saveCourse",
						"Course.WS:saveCourseCategory",
						"Course.WS:saveCourseCategoryMembership",
						"Course.WS:saveGroup",
						"Course.WS:saveOrgCategory",
						"Course.WS:saveOrgCategoryMembership",
						"Course.WS:saveStaffInfo",
						"Course.WS:updateCourse",
						"Course.WS:updateOrg",
						"Course.WS:loadCoursesInTerm", 
                                                "Course.WS:addCourseToTerm", 
                                                "Course.WS:removeCourseFromTerm", 
                                                "Course.WS:loadTerm", 
                                                "Course.WS:loadTermByCourseId", 
                                                "Course.WS:saveTerm", 
                                                "Course.WS:removeTerm", 
                                                "Course.WS:loadTerms", 
                                                "Course.WS:loadTermsByName",
						"CourseMembership.WS:deleteCourseMembership",
						"CourseMembership.WS:deleteGroupMembership",
						"CourseMembership.WS:getCourseMembership",
						"CourseMembership.WS:getCourseRoles",
				  		"CourseMembership.WS:getGroupMembership",
						"CourseMembership.WS:saveCourseMembership",
						"CourseMembership.WS:saveGroupMembership",
						"Gradebook.WS:deleteAttempts",
						"Gradebook.WS:deleteColumns",
						"Gradebook.WS:deleteGradebookTypes",
					 	"Gradebook.WS:deleteGrades",
						"Gradebook.WS:deleteGradingSchemas",
						"Gradebook.WS:getAttempts",
						"Gradebook.WS:getGradebookColumns",
						"Gradebook.WS:getGradebookTypes",
						"Gradebook.WS:getGrades",
						"Gradebook.WS:getGradingSchemas",
						"Gradebook.WS:saveAttempts",
						"Gradebook.WS:saveColumns",
						"Gradebook.WS:saveGradebookTypes",
						"Gradebook.WS:saveGrades",
						"Gradebook.WS:saveGradingSchemas",
						"Gradebook.WS:updateColumnAttribute",
						"User.WS:changeUserBatchUid",
						"User.WS:changeUserDataSourceId",
						"User.WS:deleteAddressBookEntry",
						"User.WS:deleteObserverAssociation",
						"User.WS:deleteUser",
						"User.WS:deleteUserByInstitutionRole",
						"User.WS:getAddressBookEntry",
						"User.WS:getInstitutionRoles",
						"User.WS:getObservee",
						"User.WS:getSystemRoles",
						"User.WS:getUser",
						"User.WS:getUserInstitutionRoles",
						"User.WS:saveAddressBookEntry",
						"User.WS:saveObserverAssociation",
						"User.WS:saveUser",
						"Util.WS:checkEntitlement",
						"Util.WS:deleteSetting",
						"Util.WS:getDataSources",
						"Util.WS:loadSetting",
						"Util.WS:saveSetting"
	    };
			
	    // Create empty tickets array.
            string [] tickets = null;

            // Register the proxy tool.
            RegisterToolResultVO result = ws.registerTool("Blackboard Developer Experience C-Sharp Sample Tool", regpass, secret, tools, tickets);

            // If registration is successful
            if (result.status)
            {
                Console.WriteLine("Success - tool registered");
                string proxyToolGuid = result.proxyToolGuid;
                if (proxyToolGuid != null && proxyToolGuid.Length > 0)
                {
                    Console.WriteLine("Proxy Tool GUID: " + proxyToolGuid);
                }
                return (true);
            }
            else
            {
                Console.WriteLine("Failed  - tool not registered (to re-register you must clear the password on the server):");
                for (int i = 0; i < result.failureErrors.Length; i++)
                {
                    Console.WriteLine(result.failureErrors[i]);
                }
                Console.WriteLine(ws.getLastError());
                return (false);
            }
        }

        static void initWrappers()
        {
            // Initialize the wrappers used for this sample.
            ctx = ws.getContextWrapper();
            crs = ws.getCourseWrapper();
            crm = ws.getCourseMembershipWrapper();
            usr = ws.getUserWrapper();

        }

        static String[,] getCourseList(String courseuser)
        {
            // Create a two dimensional array to house the course and membership data
            String[,] courseList = new String[10000,4];
            
            // Add headers as the first element of the array
            courseList[0,0] = "COURSE ID"; 
            courseList[0,1] = "COURSE NAME";
            courseList[0,2] = "MEMBERSHIP ID"; 
            courseList[0,3] = "COURSE ROLE";

            if ( DEBUG)
                Console.WriteLine(courseList[0, 0] + "," + courseList[0, 1] + "," + courseList[0, 2] + "," + courseList[0, 3]);
  
            // Get the list of courseIds associated with the user requested.
            CourseIdVO [] courses = ctx.getMemberships(courseuser);

            if (courses == null)
                return courseList;

            // Initialize a user filter, set to get user by username and availability.
            UserFilter uf = new UserFilter();
            
            uf.filterType = 6;
            uf.filterTypeSpecified = true;
            uf.name = new string[] { courseuser };

            // Get the user object
            UserVO [] user = usr.getUser(uf);

            if (user == null)
                return (courseList);

            int i = 1;

            // Iterate through the course list returned from contextWS.getMemberships()
            foreach (CourseIdVO courseIdVO in courses)
            {
                try
                {
                    // Grab the course Id
                    String courseId = courseIdVO.externalId;

                    // Initialize a new Course Filter and Membership Filter
                    CourseFilter cf = new CourseFilter();
                    MembershipFilter mf = new MembershipFilter();

                    // Set course filter to search for courses by user Id. Yes, this is redundant, however
                    // ContextWS.getMemberships returns both courses and organizations. This only retrieves courses
                    cf.filterType = 3;
                    cf.filterTypeSpecified = true;
                    cf.ids = new string[] { courseId };

                    // Set the membership filter to get memberships by course Id and UserId.
                    // Getting by user Id only (filter type 5) always fails. The course Id will be added
                    // during the foreach loop below.
                    mf.filterType = 6;
                    mf.filterTypeSpecified = true;
                    mf.userIds = new string[] { user[0].id };

                    // Load courses according to the course filter above
                    CourseVO[] course = crs.loadCourses(cf);

                    // if course is null, either the call failed, or the courseId actually refers to an organization.
                    if (course[0] == null)
                    {
                        continue;
                    }
                    else
                    {
                        // Add the current course Id to the membership filter
                        mf.courseIds = new string[] { courseId };

                        // Get Course memberships for the given user and course, as specified in the membership filter
                        CourseMembershipVO[] memberships = crm.loadCourseMembership(courseId, mf);

                        // If memberships were returned...
                        if (memberships != null)
                        {
                            // add the course id, the course name, the membership pk1, and the role id
                            courseList[i, 0] = course[0].courseId;
                            courseList[i, 1] = course[0].name;
                            courseList[i, 2] = memberships[0].id;
                            courseList[i, 3] = memberships[0].roleId;
                            if (DEBUG)
                                Console.WriteLine(i + ": " + courseList[i, 0] + "," + courseList[i, 1] + "," + courseList[i, 2] + "," + courseList[i, 3]);
                            i++;
                        }
                    }
                }
                catch (Exception e)
                {
                    // This error handling is not very useful, but essentially it is likely failing because of a 
                    // NullReferenceException, so the current courselist is returned.
                    return (courseList);
                }
            }
            // Finished processing, return courseLIst.
            return (courseList);
        }

        static public String[,] getData(String host, String vendor, String program, String secret, String username, string userpass, String logintype, String courseuser)
        {
            // If not logged in already...
            if (!loggedIn)
            {
                // Initialize and configure web service wrapper
                ws = new WebserviceWrapper(host, vendor, program, EXPECTED_LIFE);

                // Context.WS initialize to establish session and get session Id
                ws.initialize_v1();

                if(logintype.Equals("tool"))
                {
                    // Login as proxy Tool
                    loggedIn = ws.loginTool(secret);
                }
                else
                {
                    // Login as user
                    loggedIn = ws.loginUser(username,userpass);
                }

                if (!loggedIn)
                {
                    Console.WriteLine("Login " + logintype + " failed: " + ws.getLastError());
                    return null;
                }
            }

            //Initialize the web service wrappers necessary for this sample
            initWrappers();

            // Get a list of courses for this user
            String[,] courseList = getCourseList(courseuser);

            // Return the courseList to the form for processing
            return(courseList);


        }
    }
}
