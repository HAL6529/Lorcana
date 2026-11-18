using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_028_JA_08 : CardInfo
{
    public CardInfo_028_JA_08()
    {
        this.cardNo = "028_JA_08";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "プルート";
        this.cardName2 = "長年の愛犬";
        this.power = 2;
        this.toughness = 7;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.RaquelVillanueva;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber, EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ReignOfJafar;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
