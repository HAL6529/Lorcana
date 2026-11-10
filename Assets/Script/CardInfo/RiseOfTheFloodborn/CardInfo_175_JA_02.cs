using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_175_JA_02 : CardInfo
{
    public CardInfo_175_JA_02()
    {
        this.cardNo = "175_JA_02";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "É{ÉSèêí∑";
        this.cardName2 = "àÍñ⁄íuÇ©ÇÍÇΩåxäØ";
        this.power = 2;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AdamBunch;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
