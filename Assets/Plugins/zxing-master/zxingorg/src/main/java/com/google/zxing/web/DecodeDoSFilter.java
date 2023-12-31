/*
 * Copyright 2019 ZXing authors
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

package com.google.zxing.web;

import jakarta.servlet.annotation.WebFilter;
import jakarta.servlet.annotation.WebInitParam;

/**
 * Protect the /decode endpoint from too many requests.
 */
@WebFilter(urlPatterns = {"/w/decode"}, initParams = {
  @WebInitParam(name = "maxAccessPerTime", value = "60"),
  @WebInitParam(name = "accessTimeSec", value = "60"),
  @WebInitParam(name = "maxEntries", value = "100000"),
  @WebInitParam(name = "maxLoad", value = "0.9")
})
public final class DecodeDoSFilter extends DoSFilter {
  // no additional implementation
}
