using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_179_JA_04 : CardInfo
{
    public CardInfo_179_JA_04()
    {
        this.cardNo = "179_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ドナルドダック";
        this.cardName2 = "バッカニーア";
        this.power = 3;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.FedericoMCugliari;
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
