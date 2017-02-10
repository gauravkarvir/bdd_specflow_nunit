jsonPWrapper ({
  "Features": [
    {
      "RelativeFolder": "Login.feature",
      "Feature": {
        "Name": "Users with different permission levels can successfully log into,",
        "Description": " and log off the GO Platform application",
        "FeatureElements": [
          {
            "Name": "Login navigation",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I navigate to Go Login Page"
              }
            ],
            "Tags": [
              "@login"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "userType"
                  ],
                  "DataRows": [
                    [
                      "xebsysadmin"
                    ],
                    [
                      "xebiumorgoneauthoriseduser"
                    ],
                    [
                      "xebiumorgonecustomeradministrator"
                    ],
                    [
                      "xebiumorgoneorganisationadministrator"
                    ],
                    [
                      "xebiumorgoneinvisibleuser"
                    ],
                    [
                      "xebiumorgoneconnectoradministratortierone"
                    ],
                    [
                      "xebiumorgonecustomeradministratorwithmailboxprovisioned"
                    ]
                  ]
                }
              }
            ],
            "Name": "Users with various permissions can Login and LogOut",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I navigate to Go Login Page"
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I enter login details for <userType>"
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "the user is successfully logged on and is on the Home Page"
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "the user logs off"
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "the user is successfully logged off"
              }
            ],
            "Tags": [
              "@login"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          }
        ],
        "Result": {
          "WasExecuted": true,
          "WasSuccessful": true
        },
        "Tags": [
          "@web"
        ]
      },
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true
      }
    },
    {
      "RelativeFolder": "Logout.feature",
      "Feature": {
        "Name": "User can log out",
        "FeatureElements": [
          {
            "Name": "User navigation",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I navigate to Go Login Page"
              }
            ],
            "Tags": [
              "@logout"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          },
          {
            "Name": "User  can LogOut",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I navigate to Go Login Page"
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I enter login details for xebsysadmin"
              }
            ],
            "Tags": [
              "@logout"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": false
            }
          }
        ],
        "Result": {
          "WasExecuted": true,
          "WasSuccessful": false
        },
        "Tags": [
          "@web"
        ]
      },
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": false
      }
    },
    {
      "RelativeFolder": "LandingPage.feature",
      "Feature": {
        "Name": "Unauthorised user can access the page and perform search",
        "Description": "\tIn order to get 0 ore more results",
        "FeatureElements": [
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "personType"
                  ],
                  "DataRows": [
                    [
                      "person1"
                    ]
                  ]
                }
              }
            ],
            "Name": "Unauthorised user perform quick person search",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I navigate to LandingPage"
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I do quick search of a person for <personType>"
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I press FreeTextSearch button"
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I get person search results"
              }
            ],
            "Tags": [
              "@LandingPage",
              "@Search"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "organisationType"
                  ],
                  "DataRows": [
                    [
                      "xebiumrootorganisation"
                    ],
                    [
                      "xeborganisation"
                    ],
                    [
                      "xebiumorgoneshortname"
                    ]
                  ]
                }
              }
            ],
            "Name": "Unauthorised user perform quick organisation search",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I navigate to LandingPage"
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I do quick search of a organisation for <organisationType>"
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I press FreeTextSearch button"
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I get organisation search results"
              }
            ],
            "Tags": [
              "@LandingPage",
              "@Search"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "organisationType"
                  ],
                  "DataRows": [
                    [
                      "xebiumrootorganisation"
                    ],
                    [
                      "xeborganisation"
                    ]
                  ]
                }
              }
            ],
            "Name": "Unauthorised user perform organisation detail search",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I navigate to LandingPage"
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I click on organisation search tab"
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I do detail organisation search for organisation <organisationType>"
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I press the OrganisationSearch button"
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I get organisation search results"
              }
            ],
            "Tags": [
              "@LandingPage",
              "@Search"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          },
          {
            "Examples": [
              {
                "Name": "",
                "TableArgument": {
                  "HeaderRow": [
                    "personType"
                  ],
                  "DataRows": [
                    [
                      "person1"
                    ],
                    [
                      "person2"
                    ],
                    [
                      "person3"
                    ],
                    [
                      "person4"
                    ]
                  ]
                }
              }
            ],
            "Name": "Unauthorised user performs person search",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I navigate to LandingPage"
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I enter search details a person for <personType>"
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "I get person search results"
              }
            ],
            "Tags": [
              "@LandingPage"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          }
        ],
        "Result": {
          "WasExecuted": false,
          "WasSuccessful": false
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false
      }
    },
    {
      "RelativeFolder": "DelegatedAdmin.feature",
      "Feature": {
        "Name": "DelegatedAdmin",
        "Description": "\tIn order to avoid silly mistakes\r\n\tAs a math idiot\r\n\tI want to be told the sum of two numbers",
        "FeatureElements": [
          {
            "Name": "Add two numbers",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "I have entered 50 into the calculator"
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "I have entered 70 into the calculator"
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "I press add"
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "the result should be 120 on the screen"
              }
            ],
            "Tags": [
              "@mytag"
            ],
            "Result": {
              "WasExecuted": false,
              "WasSuccessful": false
            }
          }
        ],
        "Result": {
          "WasExecuted": false,
          "WasSuccessful": false
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": false,
        "WasSuccessful": false
      }
    }
  ],
  "Configuration": {
    "GeneratedOn": "8 June 2016 11:39:34"
  }
});