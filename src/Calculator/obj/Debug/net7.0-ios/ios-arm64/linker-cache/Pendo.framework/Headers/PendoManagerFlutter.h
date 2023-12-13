//
//  PendoManagerFlutter.h
//  PendoSDK
//
//  Created by Maxim Shnirman on 07/09/2023.
//  Copyright © 2023 Pendo.io. All rights reserved.
//

#import <Foundation/Foundation.h>

NS_ASSUME_NONNULL_BEGIN

@interface PendoManagerFlutter : NSObject
+ (void)screenChanged:(NSString *)screenId info:(NSDictionary *_Nullable)info;
@end

NS_ASSUME_NONNULL_END
