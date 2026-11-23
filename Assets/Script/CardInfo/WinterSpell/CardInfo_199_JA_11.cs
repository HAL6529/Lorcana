using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_199_JA_11 : CardInfo
{
    public CardInfo_199_JA_11()
    {
        this.cardNo = "199_JA_11";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "冬の魔法";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.MatthewOates;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpell;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Action;
        this.rare = EnumController.Rare.Uncommon;
    }
}
