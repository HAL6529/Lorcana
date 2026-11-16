using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_211_JA_06 : CardInfo
{
    public CardInfo_211_JA_06()
    {
        this.cardNo = "211_JA_06";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "デイジーダック";
        this.cardName2 = "海賊船長";
        this.power = 3;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.FedericoMariaCugliari;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.AzuriteSea;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
