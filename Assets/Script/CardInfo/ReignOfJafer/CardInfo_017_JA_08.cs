using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_017_JA_08 : CardInfo
{
    public CardInfo_017_JA_08()
    {
        this.cardNo = "017_JA_08";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "大佐";
        this.cardName2 = "シープドッグ爺さん";
        this.power = 3;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.MarianaMoreno;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
