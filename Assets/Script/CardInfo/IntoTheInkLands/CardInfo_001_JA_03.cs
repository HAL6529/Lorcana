using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_001_JA_03 : CardInfo
{
    public CardInfo_001_JA_03()
    {
        this.cardNo = "001_JA_03";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "バルー";
        this.cardName2 = "フォン・ブルーインヴァルト13世";
        this.power = 0;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CamKendell;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheJungleBook;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
