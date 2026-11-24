using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_191_JA_12 : CardInfo
{
    public CardInfo_191_JA_12()
    {
        this.cardNo = "191_JA_12";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "メリダ";
        this.cardName2 = "おそろしの射手";
        this.power = 3;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MaxUlichney;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Brave;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
