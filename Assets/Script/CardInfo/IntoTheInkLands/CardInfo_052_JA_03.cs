using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_052_JA_03 : CardInfo
{
    public CardInfo_052_JA_03()
    {
        this.cardNo = "052_JA_03";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "ママ・オーディ";
        this.cardName2 = "知恵を授ける声";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Ally, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
