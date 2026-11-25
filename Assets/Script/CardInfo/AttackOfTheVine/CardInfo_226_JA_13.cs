using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_226_JA_13 : CardInfo
{
    public CardInfo_226_JA_13()
    {
        this.cardNo = "226_JA_13";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "マイク・ワゾウスキ";
        this.cardName2 = "トップを目指すヒーロー";
        this.power = 0;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.LyleCruse;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Monster };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AttackOfTheVine;
        this.title = EnumController.Title.MonstersInc;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
