//
//  PendoPublicExtensions.h
//  PendoSDK
//
//  Created by Noam Bar-Touv on 27/10/2023.
//  Copyright © 2023 Pendo.io. All rights reserved.
//

#import <UIKit/UIKit.h>

NS_ASSUME_NONNULL_BEGIN

@interface UIView (PendoPublicExtensions)

/**
 @brief this method makes the view act as a taggable/clickable object by the Pendo SDK. Recognition of the object requires that the view inherit from UIResponder.
 @discussion this method will treat passed in object to be counted as a taggable/clickable object by the Pendo SDK.
 this method will stop treating an object as taggable/clickable object once its stopped being visible on screen.
 */
- (void)pendoRecognizeClickAnalytics;
@end

NS_ASSUME_NONNULL_END
