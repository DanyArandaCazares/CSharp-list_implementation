﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace java_list_CSharp
{
    internal class LinkedList<T>:List<T>
    {
        private Node<T> head;
        private Node<T> tail;
        private int size;

        public void increaseSize()
        {
            size++;
        }
        public void addAtTail(T data)
        {
            Node<T> newNode = new();
            newNode.data = data;
            newNode.previous = tail;
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                tail.next = newNode;
            }
            tail = newNode;
            size++;
        }
        public void addAtHead(T data)
        {
            Node<T> node = new();
            node.data = data;
            if (head == null)
            {
                head = node;
                tail = node;
                size++;
                return;
            }
            node.next = head;
            head.previous = node;
            head = node;
            size++;
        }
        public void remove(int index)
        {
            Node<T> iterator = head;
            if (head == null)
            {
                return;
            }
            for (int i = 1; i < size && index > 0; i++)
            {
                if (i == index && iterator.next == null)
                {
                    if (iterator.previous != null)
                    {
                        tail = iterator.previous;
                        iterator.previous.next = null;
                        size--;
                        return;
                    }
                    else
                    {
                        head = null;
                        tail = null;
                        size--;
                        return;
                    }
                }
                else if (i == index && iterator.previous == null)
                {
                    head = iterator.next;
                    iterator.next.previous = null;
                    size--;
                    return;
                }
                else if (i == index)
                {
                    iterator.previous.next = iterator.next;
                    iterator.next.previous = iterator.previous;
                    size--;
                }
                iterator = iterator.next;
            }
        }
        public void removeAll()
        {
            tail = null;
            head = null;
            size = 0;
        }
        public void setAt(int index, T data)
        {
            Node<T> iterator = head;
            if (index > size)
            {
                return;
            }
            for (int i = 1; i < index; i++)
            {
                iterator = iterator.next;
            }
            iterator.data = data;
        }
        public T getAt(int index)
        {
            Node<T> iterator = head;
            for (int i = 1; i < index; i++)
            {
                iterator = iterator.next;
            }
            return iterator.data;
        }
        public void removeAllWithValue(T data)
        {
            Node<T> iterator = head;
            if (size == 0)
            {
                return;
            }
            for (int i = 0; iterator != null; i++)
            {
                //String comp = iterator.data;
                if (iterator.data.Equals(data) && (iterator.next == null))
                {
                    if (iterator.previous != null)
                    {
                        tail = iterator.previous;
                        iterator.previous.next = null;
                        size--;
                    }
                    else
                    {
                        head = null;
                        tail = null;
                        size--;
                    }
                }
                else if (iterator.data.Equals(data) && (iterator.next != null))
                {
                    if (iterator == head)
                    {
                        head = iterator.next;
                        iterator.next.previous = iterator.previous;
                        size--;
                    }
                    else
                    {
                        iterator.next.previous = iterator.previous;
                        iterator.previous.next = iterator.next;
                        size--;
                    }
                }
                else if (iterator.data.Equals(data) && (iterator.previous == null))
                {
                    head = iterator.next;
                    iterator.next.previous = null;
                    size--;
                }
                else if (iterator.data.Equals(data))
                {
                    iterator.previous.next = iterator.next;
                    iterator.next.previous = iterator.previous;
                    size--;
                }
                iterator = iterator.next;
            }
        }
        public int getSize()
        {
            return size;
        }
        public Iterator<T> getIterator()
        {
            return new LinkedListIterator<T>(head);
        }
    }
}
