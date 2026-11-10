using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_141_JA_02 : CardInfo
{
    public CardInfo_141_JA_02()
    {
        this.cardNo = "141_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ÉCÉÇÉÄÉV";
        this.cardName2 = "à”ñ°ê[Ç»â˙ÇﬂâÆ";
        this.power = 1;
        this.toughness = 3;
        this.lore = 3;
        this.illustrator = EnumController.Illustrator.CoryGodbey;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
