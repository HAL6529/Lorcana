using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_167_JA_04 : CardInfo
{
    public CardInfo_167_JA_04()
    {
        this.cardNo = "167_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "àÃëÂÇ»ÇÈêŒëúÇÃó¥";
        this.cardName2 = "";
        this.power = -1;
        this.toughness = -1;
        this.lore = -1;
        this.illustrator = EnumController.Illustrator.RyanBittner;
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Item;
        this.rare = EnumController.Rare.Uncommon;
    }
}
