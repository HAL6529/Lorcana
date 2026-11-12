using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_095_JA_07 : CardInfo
{
    public CardInfo_095_JA_07()
    {
        this.cardNo = "095_JA_07";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "ハートの女王";
        this.cardName2 = "豹変する暴君";
        this.power = 2;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.AlicePisoni;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald, EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
