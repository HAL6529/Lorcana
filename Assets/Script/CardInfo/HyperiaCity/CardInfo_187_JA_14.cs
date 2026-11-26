using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_187_JA_14 : CardInfo
{
    public CardInfo_187_JA_14()
    {
        this.cardNo = "187_JA_14";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "マリー";
        this.cardName2 = "みつかっちゃった";
        this.power = 2;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.DefneTozumAndLivioCacciatore;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.TheAristocats;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
