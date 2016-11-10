# 马克飞象笔记自动转换为Octopress本地站点博客和CSDN博客 --- 2016年11月11日 星期五

## GUI-Evernote-Auto-converted-to-Octopress-local-site-blog-and-CSDN-blog

### 2016年11月11日 ---


---

这个项目保存在GitHub上：https://github.com/AoboJaing/Evernote-to-Octopress-CSDN

本地路径：D:\WorkSpace\vs2010_ws\c#_ws\Evernote-to-Octopress-CSDN

使用的开发环境：VS2010
使用的编程语言：C#


---

## 1.0 设计这个软件，让它实现的功能：

通过马克飞象笔记写完并保持的文件，将这个文件自动转换到本地**Octopress**博客站点，接着在将其转换为CSDN博客。自动上传。

---

## 1.1 举例

现在我将马克飞象写好的笔记保持到本地（如果笔记里面有图片，保存就是一个压缩包，需要解压）：

![Alt text](./img/1478802745501.png)

![Alt text](./img/1478802822561.png)

通过我设计的这个软件，将这个文件里面的`.md`文件自动保存复制到：`F:\octopress\source\_posts`路径里面，同时将这个文件的名字修改为自定的名字，并且文件后缀改为：`.markdown`。
就这在`F:\octopress\source\images`路径里面创建一个自定义的名字的文件夹，并将所有的图片复制到这个新文件夹里面。
接着，我们修改`.markdown`文件里面的内容，将里面链接图片的路径全部设置为正确的路径。
这样，本地的**Octopress**博客站点就转换完成了，接着执行`rake preview` 预览本地博客。最后执行`rake generate`，然后执行 `rake deploy` 将博客站点上传到云端。

接着将得到的`.markdown`文件里面的内容复制一份，并将里面所有的链接图片的地址前面加上`http://www.aobosir.com/`，目的是为了得到正确的图片地址。

接着自动登入我的 CSDN 的账号，写博客，将内容粘贴到上面，发表。

---

## 1.2 所以，整个过程，用户需要输入

马克飞象笔记 转为 Octopress

1. 马克飞象笔记解压后的文件夹的路径（e.g. : `D:\WorkSpace\python_ws\NoteBook\Python 网络爬虫 011 (高级功能)  支持代理proxy — 让爬虫可以翻墙爬取网站 — Ongoing— 2016年9月19日 星期一`）
2. 重新命名的英文名字（e.g. :  `2016-9-19-Python-Web-Crawler-011-Proxy`）
3. Octopress本地站点路径（e.g. : `F:\octopress`）

---

Octopress 转为 CSDN

1. CSDN的用户名和密码
2. 博客的5个标签
3. 原创 和 博客分类 和 放置的地方


## 1.3 所以，分两个大步骤进行

1. 马克飞象笔记 转为 Octopress
2. Octopress 转为 CSDN

---

# 2 第一大步 ： 马克飞象笔记 转为 Octopress

## 2.0 详细的设计步骤

1. 设计GUI界面
2. 选择**马克飞象笔记解压后的文件夹的路径**
3. 复制文件夹里面的`.md`文件到目标文件夹里面
4. 并将`.md`文件的文件名改为指定的新的名字，并将后缀名改为`.markdown`
5. 在`F:\octopress\source\images`路径里面，新建一个文件夹（就以指定英文名创建）。
6. 将**马克飞象笔记解压后的文件夹的路径**里面的图片文件全部复制到刚刚创建的文件夹里面。
7. 调用`python`脚本 来修改`.markdown` 文件里面图片的地址
8. 调用 `python`脚本，执行命令行工具，来上传同步云端的博客站点。

---


 









---

# 3 第二大步 ： Octopress 转为 CSDN






