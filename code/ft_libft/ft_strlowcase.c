char    *ft_strupcase(char *str) { 
    int i;

    i = 0;
    while(str[i] != '\0'){
        if (97 <= str[i] && str[i] <= 122){
            i++;
            continue;
        }
            
        str[i] = str[i] + 32;
        i++;
    }
    return str;
} 
  