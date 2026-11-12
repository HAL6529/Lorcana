using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_068_JA_07 : CardInfo
{
    public CardInfo_068_JA_07()
    {
        this.cardNo = "068_JA_07";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "イズマ";
        this.cardName2 = "誰よりも上";
        this.power = 3;
        this.toughness = 8;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.Queen };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst, EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.TheEmperorsNewGroove;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
