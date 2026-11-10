using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_020_JA_02 : CardInfo
{
    public CardInfo_020_JA_02()
    {
        this.cardNo = "020_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ƒ‰ƒvƒ“ƒcƒFƒ‹";
        this.cardName2 = "‘¾—z‚Ì‹P‚«";
        this.power = 1;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AubreyArcher;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Tangled;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
