/**
 * OpenAPI Petstore
 * This is a sample server Petstore server. For this sample, you can use the api key `special-key` to test the authorization filters.
 *
 * The version of the OpenAPI document: 1.0.0
 *
 * NOTE: This class is auto generated by OpenAPI-Generator 7.12.0-SNAPSHOT.
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

/*
 * UserApi.h
 *
 * 
 */

#ifndef ORG_OPENAPITOOLS_CLIENT_API_UserApi_H_
#define ORG_OPENAPITOOLS_CLIENT_API_UserApi_H_



#include "CppRestPetstoreClient/ApiClient.h"

#include "CppRestPetstoreClient/model/User.h"
#include <vector>
#include <cpprest/details/basic_types.h>
#include <boost/optional.hpp>

namespace org {
namespace openapitools {
namespace client {
namespace api {

using namespace org::openapitools::client::model;



class  UserApi 
{
public:

    explicit UserApi( std::shared_ptr<const ApiClient> apiClient );

    virtual ~UserApi();

    /// <summary>
    /// Create user
    /// </summary>
    /// <remarks>
    /// This can only be done by the logged in user.
    /// </remarks>
    /// <param name="user">Created user object</param>
    pplx::task<void> createUser(
        std::shared_ptr<User> user
    ) const;
    /// <summary>
    /// Creates list of users with given input array
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <param name="user">List of user object</param>
    pplx::task<void> createUsersWithArrayInput(
        std::vector<std::shared_ptr<User>> user
    ) const;
    /// <summary>
    /// Creates list of users with given input array
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <param name="user">List of user object</param>
    pplx::task<void> createUsersWithListInput(
        std::vector<std::shared_ptr<User>> user
    ) const;
    /// <summary>
    /// Delete user
    /// </summary>
    /// <remarks>
    /// This can only be done by the logged in user.
    /// </remarks>
    /// <param name="username">The name that needs to be deleted</param>
    pplx::task<void> deleteUser(
        utility::string_t username
    ) const;
    /// <summary>
    /// Get user by user name
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <param name="username">The name that needs to be fetched. Use user1 for testing.</param>
    pplx::task<std::shared_ptr<User>> getUserByName(
        utility::string_t username
    ) const;
    /// <summary>
    /// Logs user into the system
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    /// <param name="username">The user name for login</param>
    /// <param name="password">The password for login in clear text</param>
    pplx::task<utility::string_t> loginUser(
        utility::string_t username,
        utility::string_t password
    ) const;
    /// <summary>
    /// Logs out current logged in user session
    /// </summary>
    /// <remarks>
    /// 
    /// </remarks>
    pplx::task<void> logoutUser(
    ) const;
    /// <summary>
    /// Updated user
    /// </summary>
    /// <remarks>
    /// This can only be done by the logged in user.
    /// </remarks>
    /// <param name="username">name that need to be deleted</param>
    /// <param name="user">Updated user object</param>
    pplx::task<void> updateUser(
        utility::string_t username,
        std::shared_ptr<User> user
    ) const;

protected:
    std::shared_ptr<const ApiClient> m_ApiClient;
};

}
}
}
}

#endif /* ORG_OPENAPITOOLS_CLIENT_API_UserApi_H_ */

