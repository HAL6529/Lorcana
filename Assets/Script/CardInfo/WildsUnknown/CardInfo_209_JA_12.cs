using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_209_JA_12 : CardInfo
{
    public CardInfo_209_JA_12()
    {
        this.cardNo = "209_JA_12";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "エドナ・モード";
        this.cardName2 = "ファッションデザイナー";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.StefanoSpagnuolo;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Inventor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheIncredibles;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Epic;
    }
}
