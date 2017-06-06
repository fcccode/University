from bs4 import BeautifulSoup
import urllib.request
import requests
from lxml import html


def count_href_on_website(url):
    response = requests.get(url)
    parsed_body = html.fromstring(response.text)
    lists = parsed_body.xpath('//a/@href')
    href_count = len(lists)

    return href_count

def count_image_on_website(url):
    response = requests.get(url)
    parsed_body = html.fromstring(response.text)
    lists = parsed_body.xpath('//img/@src')
    image_count = len(lists)

    return image_count

def parse_html(url):
    response = urllib.request.urlopen(url)
    html_text = response.read()
    soup = BeautifulSoup(html_text)
    tags_name = [tag.name for tag in soup.find_all()]
    return tags_name

def counting(response):
    tags_name = ['meta', 'html', 'body', 'h1', 'h2', 'p',
                 'span', 'br', 'a', 'img', 'b', 'strong',
                 'i', 'u', 'ol', 'ul', 'tr', 'td', 'li', 'div',
                 'h3', 'href']

    result = []

    for name in tags_name:
        count = response.count(name)
        result.append({ name : count})

    return result

def take_text(url):
    tags_name = ['title', 'body', 'h1', 'h2', 'p',
                 'span', 'br', 'a','ol', 'ul', 'tr', 'td', 'li', 'div',
                 'h3']
    response = urllib.request.urlopen(url).read()
    soup = BeautifulSoup(response)
    html_size = len(soup)

    result = []
    temp = ''
    for tag in tags_name:
        for i in soup.find_all(tag):
            temp += i.text
        result.append({tag : temp})

    return result

