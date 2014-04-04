nclude <stdio.h>

int main()
{
	   char chk;   //프로그램 종료 여부 조사를 위한 변수
	      int day, month, year;
		     int yun_check;   //윤년 체크를 위한 변수
			    int day_check;   //일 체크를 위한 변수
				   while (1)
					      {
							        printf("press 'c' or 'q' : ");
									      scanf_s(" %c", &chk);

										        if (chk == 'q') 
													         break;   //q를 입력받으면 프로그램 종료
												      
												      printf("day : ");
													        scanf_s("%d", &day);
															      printf("month : ");
																        scanf_s("%d", &month);
																		      printf("year : ");
																			        scanf_s("%d", &year);

																					      if (month > 12)   //월을 먼저 검사
																							        {      
																										         printf("fail\n");
																												          continue;   //실패일 경우
																														        }
																						        if (month == 2)   //2월이라면 윤년을 체크
																									      {   
																											           if (year % 400 == 0)   //윤년
																														            {   
																																		            if (day < 30)
																																						            {
																																										               printf("ok\n");
																																													               }
																																					            else
																																									            {
																																													               printf("fail\n");
																																																               }
																																								            continue;    //continue문을 통해 switch문을 실행하지 않고 통과
																																											         }
																													            else if (year % 100 == 0)   //윤년이 아니므로 switch문으로 넘긴다
																																	         {   

																																				          }
																																         else if (year % 4 == 0)   //윤년
																																			          {      
																																						              if (day < 30)
																																										              {
																																														                 printf("ok\n");
																																																		             }
																																									              else
																																													              {
																																																	                 printf("fail\n");
																																																					             }
																																												              continue;      //continue문을 통해 switch문을 실행하지 않고 통과
																																															           }
																																		       }

																								      switch (month)
																										        {
																													      case 1: case 3: case 5: case 7: case 8: case 10: case 12:
																															           day_check = 0;
																																	            break;
																																				      case 2:
																																				         day_check = 1;
																																						          break;
																																								        case 4: case 6: case 9: case 11:
																																								           day_check = 2;
																																										            break;
																																													      }
																									        if (day_check == 0)   //31일 까지 있는 달
																												      {         
																														           if (day < 32)
																																	            {
																																					            printf("ok\n");
																																								         }
																																            else
																																				         {
																																							             printf("fail\n");
																																										          }
																																			      }
																											      else if (day_check == 1)   //윤년이 아닌 2월
																													        {      
																																         if (day < 29)
																																			          {
																																						              printf("ok\n");
																																									           }
																																		          else
																																					           {
																																								               printf("fail\n");
																																											            }
																																				        }

																												        else   //30일 까지 있는 달
																															      {               
																																	           if (day < 31)
																																				            {
																																								            printf("ok\n");
																																											         }
																																			            else
																																							         {
																																										             printf("fail\n");
																																													          }
																																						      }
																														   }
				      return 0;
}
