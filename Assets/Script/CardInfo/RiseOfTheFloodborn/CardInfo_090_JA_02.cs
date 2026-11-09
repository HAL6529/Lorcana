using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_090_JA_02 : CardInfo
{
    public CardInfo_090_JA_02()
    {
        this.cardNo = "090_JA_02";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "ÉnÅ[ÉgÇÃèóâ§";
        this.cardName2 = "Ç©ÇÒÇµÇ·Ç≠ã ";
        this.power = 1;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.MatthewRobertDavies;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
